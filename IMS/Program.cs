using IMS.Data;
using IMSClassLibrary.Context;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using IMSClassLibrary.Repos;
using IMSClassLibrary.repos;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<SystemDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SystemDbContext"));
}
);
builder.Services.AddTransient<DepartmentRepository>();
builder.Services.AddTransient<InternProjectRepository>();
builder.Services.AddTransient<UserRepository>();
builder.Services.AddTransient<UserProfileRepository>();
builder.Services.AddTransient<ProjectRepository>();
builder.Services.AddTransient<CommentRepository>();
builder.Services.AddTransient<ProfileModuleRepository>();
builder.Services.AddTransient<EmailRepository>();
builder.Services.AddTransient<ModuleRepository>();
builder.Services.AddTransient<ProfileRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
