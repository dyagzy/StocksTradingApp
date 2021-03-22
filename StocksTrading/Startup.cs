using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Stuck.Repository;
using Stuck.Repository.Configuration;
using Stuck.Repository.Infrastructure;
using Stuck.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksTrading
{
    public class Startup
    {
        private readonly string AllowedOrigin = "allowedOrigin";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddScoped<IStocksService, StocksService>();
            services.AddScoped<ISecurityService, SecurityService>();
            services.AddAutoMapper(typeof(Startup));


            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));

            // Configure Identity

           
            //services.AddIdentity<IdentityUser, IdentityRole>(options =>
            //{
            //    options.Password.RequireDigit = true;
            //    options.Password.RequireLowercase = true;
            //    options.Password.RequiredLength = 5;
            //}).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            //configure authetication
            services.Configure<JwtConfig>(Configuration.GetSection("JwtConfig"));

            services.AddAuthentication(auth =>
           {
               auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               auth.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
               auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

           }).AddJwtBearer(jwt =>
           {
               var key = Encoding.ASCII.GetBytes(Configuration["JwtConfig:Secret"]);
               jwt.SaveToken = true;
               jwt.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuerSigningKey = true,
                   IssuerSigningKey = new SymmetricSecurityKey(key),
                   ValidateIssuer = false,
                   ValidateAudience = false,
                   ValidateLifetime = true,
                   RequireExpirationTime = false
               };

           });

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();




            //services.AddIdentityCore<ApplicationUser>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            //services.Configure<IdentityOptions>(options =>
            //{
            //    options.Password.RequireDigit = false;
            //    options.Password.RequiredLength = 4;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireLowercase = false;
            //    options.Password.RequireUppercase = false;

            //});


            services.AddCors(option =>
            {
                option.AddPolicy("allowedOrigin", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            });

            services.AddControllers();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "StocksTrading", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "StocksTrading v1"));
            }


            app.UseCors(AllowedOrigin);
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
