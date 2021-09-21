using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Repository
{
    public class ReportEntryRepository : RepositoryBase<ReportEntry>, IReportEntryRepository
    {
        public ReportEntryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public ReportEntry GetReportByID(int ID)
        {
            return FindByCondition(report => report.ID == ID)
                .FirstOrDefault();
        }
        public void CreateReportEntry(ReportEntry reportEntry)
        {
            Create(reportEntry);
        }


    }
}
