using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Xdevs.Inscricao.Models
{
    public class Login
    {
        [Key]
        public int LogId { get; set; }
        public string Email{ get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}