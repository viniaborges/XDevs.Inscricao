using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Xdevs.Inscricao.Models
{
    public class context: DbContext
    {
        public DbSet<aluno> Alunos { get; set; }
    }
}