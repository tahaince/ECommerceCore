
using DataAccsessLayer.Content;
using ECommerceCore.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//sonradan eklenen

builder.Services.AddDbContext<Context>();





//builder.Services.AddRouting(options => options.LowercaseQueryStrings = true);

//builder.Services.AddMvc(config =>
//{

//    var policy = new AuthorizationPolicyBuilder()
//    .RequireAuthenticatedUser()
//    .Build();

//    config.Filters.Add(new AuthorizeFilter(policy));

//});

builder.Services.AddAuthorization();    

builder.Services.AddAuthentication(
    
    );

builder.Services.AddIdentity<AppUser, AppRole>(opts =>

{

    opts.User.RequireUniqueEmail = true;
    opts.Password.RequiredLength = 4;

}

).AddEntityFrameworkStores<Context>();






CookieBuilder cookieBuilder = new CookieBuilder();
cookieBuilder.Name = "MyCookie";
cookieBuilder.HttpOnly = false;
//cookieBuilder.Expiration = System.TimeSpan.FromDays(60);
cookieBuilder.SameSite = SameSiteMode.Lax;
cookieBuilder.SecurePolicy = CookieSecurePolicy.SameAsRequest;




builder.Services.ConfigureApplicationCookie(opts =>

{
    opts.LoginPath = new PathString("/Login/Index");
    //opts.LogoutPath= new PathString("")
    opts.Cookie = cookieBuilder;
    opts.SlidingExpiration = true;
    opts.ExpireTimeSpan = TimeSpan.FromMinutes(15);
    opts.AccessDeniedPath = new PathString("/Member/AccsessDenied/");



}
);
builder.Services.AddMvc();


var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
