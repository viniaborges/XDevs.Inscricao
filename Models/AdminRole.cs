using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Xdevs.Inscricao.Models
{
    public class AdminRole
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public List<Admin> Admins { get; set; }
    }
}