using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) 
            :base(options)
        {

        }

        public DbSet<InputType> InputTypes { get; set; }
        public DbSet<Runsheet> Runsheets { get; set; }
        public DbSet<SubSection> SubSections { get; set; }
        public DbSet<DataField> DataFields { get; set; }

    }
}
