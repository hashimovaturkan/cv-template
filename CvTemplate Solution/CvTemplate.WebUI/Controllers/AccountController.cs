using CvTemplate.Application.Core.Extensions;
using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities.Membership;
using CvTemplate.Domain.Models.FormModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace CvTemplate.WebUI.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        readonly UserManager<CvTemplateUser> userManager;
        readonly SignInManager<CvTemplateUser> signInManager;
        readonly RoleManager<CvTemplateRole> roleManager;
        readonly IConfiguration configuration;
        readonly CvTemplateDbContext db;
        public AccountController(UserManager<CvTemplateUser> userManager,
                                 SignInManager<CvTemplateUser> signInManager,
                                 RoleManager<CvTemplateRole> roleManager,
                                 IConfiguration configuration,
                                 CvTemplateDbContext db)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
            this.db = db;
        }

        [Authorize(Policy = "account.signin")]
        [Route("/signin.html")]
        public IActionResult SignIn()
        {
            return View();
        }


        [HttpPost]
        [Authorize(Policy = "account.signin")]
        [Route("/signin.html")]
        public async Task<IActionResult> SignIn(LoginFormModel user)
        {
            if (ModelState.IsValid)
            {
                CvTemplateUser foundedUser = null;
                if (user.UserName.IsEmail() == true)
                {
                    foundedUser = await userManager.FindByEmailAsync(user.UserName);
                }
                else
                {
                    foundedUser = await userManager.FindByNameAsync(user.UserName);
                }

                if (foundedUser == null || !await userManager.IsInRoleAsync(foundedUser, "User"))
                {
                    ViewBag.Message = "Your username or password is incorrect!";
                    return View(user);
                }

                if (!await userManager.IsEmailConfirmedAsync(foundedUser))
                {
                    ViewBag.Message = "Please,confirm your email!";
                    return View(user);
                }

                var sResult = await signInManager.PasswordSignInAsync(foundedUser, user.Password, true, true);

                if (sResult.Succeeded != true)
                {
                    ViewBag.Message = "Your username or password is incorrect!";
                    return View(user);
                }

                var redirectUrl = Request.Query["ReturnUrl"];
                if (!string.IsNullOrWhiteSpace(redirectUrl))
                {
                    return Redirect(redirectUrl);
                }

                return RedirectToAction("about", "Home");
            }
            ViewBag.Message = "Your username or password is incorrect!";
            return View();
        }

        [Route("/register.html")]
        public IActionResult Register()
        {
            return View();
        }

        [Authorize(Policy = "account.register")]
        [HttpPost]
        [Route("/register.html")]
        public async Task<IActionResult> Register(RegisterFormModel user)
        {
            if (ModelState.IsValid)
            {
                db.Database.BeginTransaction();
                var username = await userManager.FindByNameAsync(user.UserName);
                var email = await userManager.FindByEmailAsync(user.Email);
                if (username != null)
                    return Json(new
                    {
                        error = true,
                        message = "Your username is already used!"
                    });

                if (email != null)
                    return Json(new
                    {
                        error = true,
                        message = "Your email is already registered!"
                    });

                CvTemplateRole cvTemplateRole = new CvTemplateRole
                {
                    Name = "User"
                };

                if (!roleManager.RoleExistsAsync(cvTemplateRole.Name).Result)
                {
                    var createRole = roleManager.CreateAsync(cvTemplateRole).Result;
                    if (!createRole.Succeeded)
                    {
                        return Json(new
                        {
                            error = true,
                            message = "Error, please try again!"
                        });
                    }
                }
                else
                {
                    //var role = roleManager.FindByNameAsync(riodeRole.Name).Result;
                }

                string password = user.Password;
                var cvTemplateUser = new CvTemplateUser()
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    EmailConfirmed = false
                };

                //password 3den yxuari olmalidi
                var createdUser = userManager.CreateAsync(cvTemplateUser, password).Result;

                if (createdUser.Succeeded)
                {
                    userManager.AddToRoleAsync(cvTemplateUser, cvTemplateRole.Name).Wait();

                    string token = userManager.GenerateEmailConfirmationTokenAsync(cvTemplateUser).Result;
                    string path = $"{Request.Scheme}://{Request.Host}/email-confirm?email={cvTemplateUser.Email}&token={token}";
                    var sendMail = configuration.SendEmail(user.Email, "Riode email confirming", $"Please, use <a href={path}>this link</a> for confirming");

                    if (sendMail == false)
                    {
                        db.Database.RollbackTransaction();
                        return Json(new
                        {
                            error = true,
                            message = "Please, try again"
                        });
                    }

                    db.Database.CommitTransaction();


                    return Json(new
                    {
                        error = false,
                        message = "Successfully, please check your email!"
                    });
                }
                else
                {
                    return Json(new
                    {
                        error = true,
                        message = "Error, please try again!"
                    });
                }

            }

            return Json(new
            {
                error = true,
                message = "Incomplete data"
            });
        }

        [Route("email-confirm")]
        [Authorize(Policy = "account.emailconfirm")]
        public async Task<IActionResult> EmailConfirm(string email, string token)
        {
            var user = userManager.FindByEmailAsync(email).Result;
            if (user == null)
            {
                ViewBag.Message = "Token error!";
                return View();
            }

            token = token.Replace(" ", "+");

            if (user.EmailConfirmed == true)
            {
                ViewBag.Message = "You have already confirmed.";
                return View();
            }

            IdentityResult result = await userManager.
                        ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                ViewBag.Message = "We're excited to have you get started. Your account is confirmed successfully.";
                return View();
            }
            else
            {
                ViewBag.Message = "Error while confirming your email!";
                return View();
            }

        }

        
        [Authorize(Policy = "account.logout")]
        [Route("/logout.html")]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("About", "Home");
        }

        [Route("/accessdenied.html")]
        public IActionResult AccessDeny()
        {
            return View();
        }

    }
}
