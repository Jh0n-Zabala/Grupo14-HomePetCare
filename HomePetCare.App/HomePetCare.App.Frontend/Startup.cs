// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.AspNetCore.HttpsPolicy;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;
// using HomePetCare.App.Persistencia;

// namespace HomePetCare.App.Frontend
// {
//     public class Startup
//     {
//         public Startup(IConfiguration configuration)
//         {
//             Configuration = configuration;
//         }

//         public IConfiguration Configuration { get; }

//         // This method gets called by the runtime. Use this method to add services to the container.
//         public void ConfigureServices(IServiceCollection services)
//         {   
//             // services.AddRazorPages();
//             // services.AddControllersWithViews();
//             services.AddSingleton<IRepositorioMascota, RepositorioMascota>();
//             services.AddDbContext<HomePetCare.App.Persistencia.AppContext>();

//             //services.AddRazorPages().AddRazorRuntimeCompilation();
//             // stuff...
//             var mvcBuilder = services.AddControllersWithViews();

//             // #if DEBUG
//             //     mvcBuilder.AddRazorRuntimeCompilation();
//             // #endif
//             // more stuff...
//         }

//         // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//         public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//         {
//             if (env.IsDevelopment())
//             {
//                 app.UseDeveloperExceptionPage();
//             }
//             else
//             {
//                 app.UseExceptionHandler("/Error");
//                 // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//                 app.UseHsts();
//             }

//             app.UseHttpsRedirection();
//             app.UseStaticFiles();

//             app.UseRouting();

//             app.UseAuthentication();

//             app.UseAuthorization();

//             app.UseEndpoints(endpoints =>
//             {
//                 endpoints.MapRazorPages();
//             });
//         }
//     }
// }
