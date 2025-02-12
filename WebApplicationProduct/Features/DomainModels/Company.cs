namespace WebApplicationProduct.Features.DomainModels
{
    public class Company
    {
        public Company()
        {
            Branches = new();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Branch> Branches { get; set; }
    }
}
