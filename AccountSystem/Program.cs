using AccountSystem.DataAccess.Repository.Branches;
using AccountSystem.DataAccess.Repository.Cashiers;
using AccountSystem.DataAccess.Repository.Cities;
using AccountSystem.DataAccess.Repository.InvoiceDetails;
using AccountSystem.DataAccess.Repository.InvoiceHeaders;
using AccountSystem.Middelwere;
using AccountSystem.Models;
using AccountSystem.Options;
using Accountystem.Business.Mappings;
using Accountystem.Business.Services.Branchs;
using Accountystem.Business.Services.CashierServices;
using Accountystem.Business.Services.Cities;
using Accountystem.Business.Services.InvoiceDetails;
using Accountystem.Business.Services.InvoiceHeaders;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace AccountSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Logging.ClearProviders();
            builder.Logging.AddSerilog(
                new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("Logs/AccountSystem.txt",rollingInterval : RollingInterval.Day)
                .MinimumLevel.Information()
                .CreateLogger()
                );
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var ShaOptions = builder.Configuration.GetSection("ConnectionStrings").Get<ShaTaskOptions>();
            builder.Services.AddDbContext<ShaTaskContext>(
                options => options.
                UseSqlServer(ShaOptions?.ShaTaskDatabase, b => b.MigrationsAssembly("AccountSystem")));
            
            builder.Services.AddScoped<ICashierRepository, CashierRepo>();
            builder.Services.AddScoped<ICashierService, CashierService>();
            builder.Services.AddScoped<ICityService, CityService>();
            builder.Services.AddScoped<ICityRepository, CityRepository>();
            builder.Services.AddScoped<IBranchesRepository, BranchRepo>();
            builder.Services.AddScoped<IBrachService, BranchService>();
            builder.Services.AddScoped<IInvoiceDetailRepo, InvoiceDetailRepo>();
            builder.Services.AddScoped<IInvoiceDeltailService, InvoiceDetailService>();
            builder.Services.AddScoped<IInvoiceHeaderRepository, InvoiceHeaderRepository>();
            builder.Services.AddScoped<IInvoiceHeaderService, InvoiceHeaderService>();

            builder.Services.AddAutoMapper(typeof(AutoMapProfile));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseMiddleware<ExceptionHandlerMiddelwere>();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}