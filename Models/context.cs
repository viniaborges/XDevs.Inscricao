using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Xdevs.Inscricao.Models
{
    public class Context : DbContext
    {
        //public Context() : base("Server=localhost\\SQLEXPRESS; Database=XDevs.Inscricao; Trusted_Connection=True;") { }
        public Context() : base("Server=tcp:xdevs.database.windows.net,1433;Initial Catalog=XDevsDB;Persist Security Info=False;User ID=xdevsadmin;Password=XD3v5Pa55w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;") { }
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}