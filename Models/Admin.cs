using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Xdevs.Inscricao.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Nome{ get; set; }
        public string Email { get; set; }
        public string Password{ get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public AdminRole Role { get; set; }
    }
}