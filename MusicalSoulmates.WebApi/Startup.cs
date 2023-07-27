using Microsoft.EntityFrameworkCore;

public void ConfigureServices(IServiceCollection services)
{
    // ... other services

    // Configure DbContext with SQL Server
    services.AddDbContext<MSDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

    // ... other configurations
}