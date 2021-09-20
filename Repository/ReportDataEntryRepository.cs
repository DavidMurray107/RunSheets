using Contracts;
using Entities;
using Entities.Models;
namespace Repository
{
    public class ReportDataEntryRepository : RepositoryBase<ReportDataEntry>, IReportDataEntryRepository
    {
        public ReportDataEntryRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }
    }
}
