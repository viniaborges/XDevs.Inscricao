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
        public Context() : base("Server=localhost\\SQLEXPRESS; Database=XDevs.Inscricao; Trusted_Connection=True;") { }
        
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminRole> AdminRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<Xdevs.Inscricao.Models.Login> Logins { get; set; }
    }
}