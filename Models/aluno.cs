using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Xdevs.Inscricao.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }
        public int CPF { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        public string Celular { get; set; }
        [Display(Name = "WhatsApp")]
        public bool Whatsapp { get; set; }
        public int CEP { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "Número")]
        public int EndNumero { get; set; }
        [Display(Name = "Complemento")]
        public string EndComplemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        //Construtores
        public Aluno()
        {
        }

        public Aluno(int id, string nomeCompleto, int cpf)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            CPF = cpf;
        }

        public Aluno(int id, string nomeCompleto, int cpf, string email) : this(id, nomeCompleto, cpf)
        {
            Email = email;
        }

        public Aluno(int id, string nomeCompleto, int cpf, string celular, bool whatsapp) : this(id, nomeCompleto, cpf)
        {
            Celular = celular;
            Whatsapp = whatsapp;
        }

        public Aluno(int id, string nomeCompleto, int cpf, string email, string celular, bool whatsapp) : this(id, nomeCompleto, cpf, celular, whatsapp)
        {
            Email = email;
        }

        public Aluno(int id, string nomeCompleto, int cpf, string email, int cep, string endereco, int endNumero, string bairro, string cidade, string estado) : this(id, nomeCompleto, cpf, email)
        {
            CEP = cep;
            Endereco = endereco;
            EndNumero = endNumero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public Aluno(int id, string nomeCompleto, int cpf, string email, string celular, bool whatsapp, int cep, string endereco, int endNumero, string bairro, string cidade, string estado) : this(id, nomeCompleto, cpf, email, cep, endereco, endNumero, bairro, cidade, estado)
        {
            Celular = celular;
            Whatsapp = whatsapp;
        }
    }

    //public class Admin
    //{
    //    [Key]
    //    public int AdmId { get; set; }
    //    [Display(Name = "Usuário")]
    //    public string AdmUser { get; set; }
    //    [Display(Name = "Senha")]
    //    public string AdmPassword { get; set; }

    //    //Construtores
    //    public Admin(int id, string user, string password)
    //    {
    //        AdmId = id;
    //        AdmUser = user;
    //        AdmPassword = password;
    //    }
    //}
}