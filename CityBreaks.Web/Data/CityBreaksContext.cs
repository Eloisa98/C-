
using Microsoft.EntityFrameworkCore;
using CityBreaks.Web.Models;

namespace CityBreaks.Web.Data;

public class CityBreaksContext : DbContext
{
    public CityBreaksContext(DbContextOptions<CityBreaksContext> options) : base(options) {}

    public DbSet<Country> Countries => Set<Country>();
    public DbSet<City> Cities => Set<City>();
    public DbSet<Property> Properties => Set<Property>();
}
