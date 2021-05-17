using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContexFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para criar as migrações
            var connectionString = "Server=localhost; Port=3306; DataBase=DbApi; Uid=root; Pwd=erika03";
            //var connectionString = "Server=.\\SQLEXPRESS;Initial Catalog=DBAPI;MultipleActiveResultSets=true;User ID=sa;Password=erika03";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            optionBuilder.UseMySql(connectionString);
            //optionBuilder.UseSqlServer(connectionString);
            return new MyContext(optionBuilder.Options);
        }
    }
}
