using Microsoft.EntityFrameworkCore;
using nurAPI.Features.DataAccess.MicroServiceDbContext;
using WebApplicationProduct.Features.DataAccess.Repositories;
using WebApplicationProduct.Features.DataAccess.RepositoryInterface;
using WebApplicationProduct.Features.ServiceImplementation;
using WebApplicationProduct.Features.ServiceImplementation.ServiceInterface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(opt =>
opt.UseSqlServer(builder.Configuration.GetConnectionString("AppDbConnectionString")), ServiceLifetime.Scoped);

//Company
builder.Services.AddTransient<ICompanyRepository, CompanyRepository>();
builder.Services.AddTransient<ICompanyService, CompanyService>();

// Add services to the container.

var app = builder.Build();


app.UseRouting();
app.MapControllers();
 
app.Run();
 