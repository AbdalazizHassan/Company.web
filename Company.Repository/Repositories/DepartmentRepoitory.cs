using Combany.Data.Contexts;
using Combany.Data.Models;
using Company.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Repositories
{
    public class DepartmentRepoitory : GenericRepository<Department> , IDepartmentRepoitory
    {
        private readonly CompanyDbContext _context;

        public DepartmentRepoitory(CompanyDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

