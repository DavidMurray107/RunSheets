using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class DataFieldRepository : RepositoryBase<DataField>, IDataFieldRepository
    {
        public DataFieldRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }
    }
}
