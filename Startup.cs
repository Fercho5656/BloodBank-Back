using System.Text.Json.Serialization;
using bloodbank.Context;
using bloodbank.Services;
using BloodBank_Backend.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace bloodbank {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            services.AddCors();

            services.AddDbContext<BloodBankContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("dev")));

            //Add Services
            services.AddScoped<IRolesServices, RolesService>();
            services.AddScoped<IContactInfoService, ContactInfoService>();
            services.AddScoped<IBloodBankService, BloodBankService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IHospitalService, HospitalService>();
            services.AddScoped<IBloodGroupService, BloodGroupService>();
            services.AddScoped<IBloodBank_BloodGroupService, BloodBank_BloodGroupService>();
            services.AddScoped<IDonorService, DonorService>();
            services.AddScoped<IRequestService, RequestService>();

            services.AddControllers()
            .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
            services.AddAutoMapper(typeof(Startup));
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "bloodbank", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "bloodbank v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(opt => {
                opt.WithOrigins("http://localhost:8080");
                opt.AllowAnyMethod();
                opt.AllowAnyHeader();
            });

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
