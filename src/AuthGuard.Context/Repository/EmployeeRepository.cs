using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthGuard.Context.Repository.Base;
using AuthGuard.Model;

namespace AuthGuard.Context.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AuthGuardContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
