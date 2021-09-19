using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class SubSectionRepository : RepositoryBase<SubSection>, ISubSectionRepository
    {
        public SubSectionRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }
    }
}
