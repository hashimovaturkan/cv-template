using CvTemplate.Domain.Models.Entities;
using CvTemplate.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.DataContexts
{
    public class CvTemplateDbContext: IdentityDbContext<CvTemplateUser, CvTemplateRole, int, CvTemplateUserClaim, CvTemplateUserRole, CvTemplateUserLogin, CvTemplateRoleClaim, CvTemplateUserToken>
    {
        public CvTemplateDbContext():base()
        {

        }
        public CvTemplateDbContext(DbContextOptions options):base(options)
        {

        }



        public DbSet<BlogPost> BlogPosts { get; set; }
        //public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<AcademicBackGround> AcademicBackGrounds { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<ContactPost> ContactPosts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<PersonalSetting> PersonalSettings { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialProfile> SocialProfiles { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Resume> Resumes { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS; Initial Catalog=CvTemplate; User Id=sa; Password=query;");
        //    }

        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CvTemplateUser>(e => {

                e.ToTable("Users", "Membership");
            });

            builder.Entity<CvTemplateRole>(e => {

                e.ToTable("Roles", "Membership");
            });

            builder.Entity<CvTemplateRoleClaim>(e => {

                e.ToTable("RoleClaims", "Membership");
            });

            builder.Entity<CvTemplateUserClaim>(e => {

                e.ToTable("UserClaims", "Membership");
            });

            builder.Entity<CvTemplateUserLogin>(e => {

                e.ToTable("UserLogins", "Membership");
            });

            builder.Entity<CvTemplateUserToken>(e => {

                e.ToTable("UserTokens", "Membership");
            });

            builder.Entity<CvTemplateUserRole>(e => {

                e.ToTable("UserRoles", "Membership");
            });
        }


    }
}
