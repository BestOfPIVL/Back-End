<<<<<<< HEAD
﻿
ASP.NET MVC core dependencies have been added to the project.
=======
﻿ASP.NET Core MVC dependencies have been added to the project.
>>>>>>> 0def423f6e8ae54053a12ef21b8e0f30c7eb897a
(These dependencies include packages required to enable scaffolding)

However you may still need to do make changes to your project.

1. Suggested changes to Startup class:
    1.1 Add a constructor:
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
<<<<<<< HEAD
=======

>>>>>>> 0def423f6e8ae54053a12ef21b8e0f30c7eb897a
    1.2 Add MVC services:
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
       }

<<<<<<< HEAD
    1.3 Configure web app to use use Configuration and use MVC routing:
=======
    1.3 Configure web app to use MVC routing:
>>>>>>> 0def423f6e8ae54053a12ef21b8e0f30c7eb897a

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

<<<<<<< HEAD
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

=======
>>>>>>> 0def423f6e8ae54053a12ef21b8e0f30c7eb897a
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
