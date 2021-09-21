using Entities.Models;

namespace Contracts
{
    public interface IReportEntryRepository : IRepositoryBase<ReportEntry>
    {
        public ReportEntry GetReportByID(int ID);
        void CreateReportEntry(ReportEntry reportEntry);
    }
}
