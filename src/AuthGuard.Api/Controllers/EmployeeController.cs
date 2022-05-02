using System.Net;
using System.Threading.Tasks;
using AuthGuard.Bussiness.Services;
using AuthGuard.Contracts.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthGuard.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] PostEmployeeRequest request)
        {
            var response = await _employeeService.PostEmployee(request);

            return StatusCode((int)HttpStatusCode.Created, response);
        }

        [HttpGet("")]
        public async Task<IActionResult> Get([FromQuery] GetEmployeeRequest request)
        {
            var response = await _employeeService.GetEmployee(request);

            return StatusCode((int)HttpStatusCode.OK, response);
        }

        [HttpGet("All")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _employeeService.GetEmployee(null);

            return StatusCode((int)HttpStatusCode.OK, response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _employeeService.DeleteEmployee(id);

            return StatusCode((int)HttpStatusCode.OK, response);
        }



    }
}
