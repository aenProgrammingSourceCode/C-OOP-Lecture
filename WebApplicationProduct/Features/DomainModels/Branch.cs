﻿namespace WebApplicationProduct.Features.DomainModels
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
