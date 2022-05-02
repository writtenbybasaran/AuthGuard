using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthGuard.Contracts.Requests;
using AuthGuard.Contracts.Responses;
using AuthGuard.Model;
using AutoMapper;
using AutoMapper.Configuration;

namespace AuthGuard.Bussiness.Mappers
{
    public class EmployeeMappers : Profile
    {
        public EmployeeMappers()
        {
            CreateMap<Employee, EmployeeResponse>();
            CreateMap<PostEmployeeRequest, Employee>();
        }
    }
}
