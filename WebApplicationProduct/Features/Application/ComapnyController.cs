using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationProduct.Features.ServiceImplementation.ServiceInterface;
using WebApplicationProduct.Features.ServiceImplementation.ServiceInterface.Messaging;

namespace WebApplicationProduct.Features.Application
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ComapnyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public ComapnyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        public IActionResult Create([FromQuery] CompanyRequest formRequest)
        {
            CompanyRequest request = new()
            {
                Name = formRequest.Name
            };
            _companyService.Add(request);
            return Ok("Success");
        }
    }
}
