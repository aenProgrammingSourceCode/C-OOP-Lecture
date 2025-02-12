using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationProduct.Features.ServiceImplementation.ServiceInterface;
using WebApplicationProduct.Features.ServiceImplementation.ServiceInterface.Messaging;

namespace WebApplicationProduct.Features.Application
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComapnyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public ComapnyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromQuery] CompanyRequest formRequest)
        {
            CompanyRequest request = new()
            {
                Name = formRequest.Name
            };
            await _companyService.Add(request);
            return Ok("Success");
        }

        [HttpGet("getby/{id}")]
        public async Task<IActionResult>GetByAsync(int id)
        {
            var response= await _companyService.GetBy(id);
            return Ok(response);
        }
    }
}
