using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AuthGuard.Common.CustomExceptions;
using AuthGuard.Context.Repository;
using AuthGuard.Context.Repository.Base;
using AuthGuard.Contracts.Requests;
using AuthGuard.Contracts.Responses;
using AuthGuard.Model;
using AutoMapper;

namespace AuthGuard.Bussiness.Services.Implementations
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EmployeeResponse> GetEmployee(GetEmployeeRequest request)
        {
            var employee = (await _repository.FindByCondition(x => x.Id == request.Id)).FirstOrDefault();

            if (employee == null)
                throw new NotFoundException("Kullanıcı bulunamadı.");

            var response = _mapper.Map<EmployeeResponse>(employee);

            return response;
        }


        public async Task<EmployeeResponse> PostEmployee(PostEmployeeRequest request)
        {
            var employee = _mapper.Map<Employee>(request);

            await _repository.Create(employee);
            await _repository.Commit();

            var response = _mapper.Map<EmployeeResponse>(employee);

            return response;
        }

        public async Task<bool> DeleteEmployee(int employeeId)
        {
            var employee = (await _repository.FindByCondition(x => x.Id == employeeId)).FirstOrDefault();

            if (employee == null)
                throw new NotFoundException("Kullanıcı bulunamadı.");

            await _repository.Delete(employee);
            return true;
        }
    }
}
