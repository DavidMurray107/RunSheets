using Contracts;
using Entities;
using Entities.Models;


namespace Repository
{
    public class InputTypeRepository : RepositoryBase<InputType>, IInputTypeRepository
    {
        public InputTypeRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }
    }
}
