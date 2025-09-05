using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Commander.Data
{
    public class CommanderContextFactory : IDesignTimeDbContextFactory<CommanderContext>
    {
        public CommanderContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CommanderContext>();

            optionsBuilder.UseSqlServer("Server=DESKTOP-RO0QFLO\\SQLEXPRESS;Initial Catalog=CommanderDB;User ID=CommanderAPI;Password=password;TrustServerCertificate=True;");

            return new CommanderContext(optionsBuilder.Options);
        }
    }
}
