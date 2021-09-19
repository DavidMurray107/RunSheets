using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace Repository
{
    public class RunsheetRepository : RepositoryBase<Runsheet>, IRunsheetRepository
    {
        public RunsheetRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }

        public IEnumerable<Runsheet> GetAllRunsheetsForInputType(int inputType)
        {
            return FindByCondition(runsheet => runsheet.InputTypeID == inputType)
                .ToList();
        }

        public Runsheet GetRunsheetByID(int ID)
        {
            return FindByCondition(runsheet => runsheet.ID == ID)
                .FirstOrDefault();
        }

        public Runsheet GetRunsheetWithSubsectionAndDatafields(int ID)
        {
            return FindByCondition(runsheet => runsheet.ID == ID)
                .Include(rs => rs.SubSections)
                    .ThenInclude(ss => ss.DataFields)
                .AsSingleQuery()
                .FirstOrDefault();
        }
    }
}
