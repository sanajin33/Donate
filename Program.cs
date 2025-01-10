using Blazored.Modal;
using Blazored.Toast;
using Donate.Components;
using Donate.Components.Account;
using Donate.Data;
using Donate.Data.Entities;
using Donate.Data.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Radzen;

namespace Donate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var PostgreSqlCS = builder.Configuration.GetConnectionString("PostgreSqlCS") ?? throw new InvalidOperationException("Connection string 'PostgreSqlCS' not found.");
            builder.Services.AddDbContextFactory<DonateDbContext>(options => options.UseNpgsql(PostgreSqlCS));

            builder.Services.AddRazorComponents().AddInteractiveServerComponents();

            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();
            builder.Services.AddRadzenComponents();
            builder.Services.AddBlazoredToast();
            builder.Services.AddBlazoredModal();
            builder.Services.AddScoped<IdentityUserAccessor>();
            builder.Services.AddScoped<IdentityRedirectManager>();
            builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
            builder.Services.AddSingleton<IEmailSender<AppUser>, EmailSender>();

            builder.Services.AddIdentity<AppUser,AppRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<DonateDbContext>()
                .AddSignInManager()
                .AddDefaultTokenProviders();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            // Add additional endpoints required by the Identity /Account Razor components.
            app.MapAdditionalIdentityEndpoints();

            app.Run();
        }
    }
}
