using CvTemplate.Application.Core.Extensions;
using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.BioModule
{
    public class BioCreateCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public class BioCreateCommandHandler : IRequestHandler<BioCreateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            public BioCreateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx)
            {
                this.ctx = ctx;
                this.db = db;
            }
            public async Task<int> Handle(BioCreateCommand request, CancellationToken cancellationToken)
            {
                if (ctx.IsModelStateValid())
                {
                    var model = new Bio();
                    model.Title = request.Title;
                    model.Content = request.Content;

                    db.Bios.Add(model);
                    await db.SaveChangesAsync();

                    return model.Id;

                }

                return 0;

            }
        }
    }
}
