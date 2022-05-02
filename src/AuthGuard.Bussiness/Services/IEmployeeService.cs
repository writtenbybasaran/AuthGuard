using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthGuard.Contracts.Requests;
using AuthGuard.Contracts.Responses;

namespace AuthGuard.Bussiness.Services
{
    public interface IEmployeeService
    {
        Task<EmployeeResponse> GetEmployee(GetEmployeeRequest request);
        Task<EmployeeResponse> PostEmployee(PostEmployeeRequest request);
        Task<bool> DeleteEmployee(int employeeId);
    }
}
