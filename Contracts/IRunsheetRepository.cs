using Entities.Models;
using System.Collections.Generic;

namespace Contracts
{
    public interface IRunsheetRepository : IRepositoryBase<Runsheet>
    {
        IEnumerable<Runsheet> GetAllRunsheetsForInputType(int inputType);
        Runsheet GetRunsheetByID(int ID);
        Runsheet GetRunsheetWithSubsectionAndDatafields(int ID);
    }
}
