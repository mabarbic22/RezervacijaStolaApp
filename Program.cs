using Microsoft.EntityFrameworkCore;
using RezervacijaStolaApp.Models.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DeskReservationDataContext") ?? throw new InvalidOperationException("Connection string 'DeskReservationDataContext' not found.");

// Add services to the container.
builder.Services.AddControllersWithViews();

//registracija baze podataka
var dbFolfer = AppDomain.CurrentDomain.BaseDirectory;
var dbPath = Path.Combine(dbFolfer, "DeskReservation.db");
builder.Services.AddDbContext<DeskReservationDataContext>(options =>
    options.UseSqlite($"DataSource={dbPath}"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
