using Contracts;
using Entities;
using Entities.Models;
namespace Repository
{
    public class ReportEntryRepository : RepositoryBase<ReportEntry>, IReportEntryRepository
    {
        public ReportEntryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
