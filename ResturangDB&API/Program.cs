using Microsoft.EntityFrameworkCore;
using ResturangDB_API.Data;
using ResturangDB_API.Data.Repos;
using ResturangDB_API.Data.Repos.IRepos;
using ResturangDB_API.Services;
using ResturangDB_API.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ResturangContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ITableRepo, TableRepo>();
builder.Services.AddScoped<ITableService, TableService>();
builder.Services.AddScoped<IMenuRepo, MenuRepo>();
builder.Services.AddScoped<IMenuService, MenuService>();
builder.Services.AddScoped<IMenuItemRepo, MenuItemRepo>();
builder.Services.AddScoped<IMenuItemService, MenuItemService>();
builder.Services.AddScoped<IBookingRepo, BookingRepo>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<StartupRepo>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var startupRepo = scope.ServiceProvider.GetRequiredService<StartupRepo>();

    await startupRepo.IsTableAvailableAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();