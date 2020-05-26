using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para criar migrações
            //var connectionString = "Server=192.168.0.102;Port=3306;Database=dbAPI;Uid=root;Pwd=loja1402";
            var connectionString = "Server=192.168.0.102;Database=dbAPI;User Id=sa;Password=loja1402!";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            //optionBuilder.UseMySql(connectionString);
            optionBuilder.UseSqlServer(connectionString);
            return new MyContext(optionBuilder.Options);
        }
    }
}
