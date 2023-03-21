using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using TaskManager_DataAccess.Data;
using Microsoft.AspNetCore.Identity;
using TaskManager_DataAccess.Repository.IRepository;
using TaskManager_DataAccess.Repository;

var builder = WebApplication.CreateBuilder(args);
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
// ��������� �������� ApplicationContext � �������� ������� � ����������
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connection));

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<ApplicationDbContext>();
//Add services to the container.
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddDefaultUI()
                .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession(Options =>
{
    Options.IdleTimeout = TimeSpan.FromMinutes(1);
    Options.Cookie.HttpOnly = true;
    Options.Cookie.IsEssential = true;
});
builder.Services.AddScoped<ITaskHeaderRepository,       TaskHeaderRepository>();
builder.Services.AddScoped<ITaskDetailRepository,       TaskDetailRepository>();
builder.Services.AddScoped<IHistoryTasksRepository,     HistoryTaskRepository>();
builder.Services.AddScoped<IStatusTaskRepository,       StatusTaskRepoSitory>();
builder.Services.AddScoped<IClientsRepository,          ClientRepository>();
builder.Services.AddScoped<ITypeTaskRepository,         TypeTaskRepository>();
builder.Services.AddScoped<IApplicationUserRepository,  ApplicationUserRepository>();
builder.Services.AddControllersWithViews();
//builder.Services.AddRazorPages();

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

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});
app.Run();
