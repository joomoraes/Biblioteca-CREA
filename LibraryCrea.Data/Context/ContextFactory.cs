using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = @"Data Source=10.0.0.2;Initial Catalog=SBOTeste;User ID=sa;Password=lbr@2016";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();

            optionBuilder.UseSqlServer(connectionString);
            return new MyContext(optionBuilder.Options);
        }

    }
}
