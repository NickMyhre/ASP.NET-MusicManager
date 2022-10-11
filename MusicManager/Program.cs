using Microsoft.EntityFrameworkCore;
using MusicManager.Configurations;
using MusicManager.Contracts;
using MusicManager.Models;
using MusicManager.Repositories;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("MusicManagerDbConnectionString");

builder.Services.AddDbContext<MusicDbContext>(options => {
    options.UseSqlServer(connectionString).EnableSensitiveDataLogging();
});

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(MapperConfig));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IArtistsRepository, ArtistsRepository>();
builder.Services.AddScoped<ISongsRepository, SongsRepository>();
builder.Services.AddScoped<IAlbumsRepository, AlbumsRepository>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{orderBy?}");

app.Run();
