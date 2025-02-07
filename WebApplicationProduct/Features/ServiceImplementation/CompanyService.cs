using nurAPI.Features.DomainModels;
using WebApplicationProduct.Features.Application;
using WebApplicationProduct.Features.DataAccess.RepositoryInterface;
using WebApplicationProduct.Features.ServiceImplementation.ServiceInterface;
using WebApplicationProduct.Features.ServiceImplementation.ServiceInterface.Messaging;

namespace WebApplicationProduct.Features.ServiceImplementation
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public async Task Add(CompanyRequest request)
        {
            Company company = new()
            {
                Name = request.Name
            };

           await _companyRepository.Add(company);
        }
    }
}
