using CvTemplate.Application.Core.Extensions;
using CvTemplate.Domain.Models.DataContexts;
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
    public class BioUpdateCommand : BioViewModel, IRequest<int>
    {
        public class BioUpdateCommandHandler : IRequestHandler<BioUpdateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            public BioUpdateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx)
            {
                this.ctx = ctx;
                this.db = db;
            }
            public async Task<int> Handle(BioUpdateCommand request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return 0;

                var model = db.Bios.FirstOrDefault(s => s.Id == request.Id && s.DeletedByUserId == null);
                if (model == null)
                    return 0;

                if (ctx.IsModelStateValid())
                {
                    model.Title = request.Title;
                    model.Content = request.Content;

                    await db.SaveChangesAsync(cancellationToken);

                    return model.Id;
                }
                return 0;
            }
        }
    }
}
