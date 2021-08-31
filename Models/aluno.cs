using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Xdevs.Inscricao.Models
{
    public class aluno
    {
        [Key]
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public bool Whatsapp { get; set; }
        public int CEP { get; set; }
        public string Endereco { get; set; }
        public int EndNumero { get; set; }
        public string EndComplemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        //Construtores
        public aluno()
        {
        }

        public aluno(int id, string nomeCompleto, int cpf)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            CPF = cpf;
        }

        public aluno(int id, string nomeCompleto, int cpf, string email) : this(id, nomeCompleto, cpf)
        {
            Email = email;
        }

        public aluno(int id, string nomeCompleto, int cpf, string celular, bool whatsapp) : this(id, nomeCompleto, cpf)
        {
            Celular = celular;
            Whatsapp = whatsapp;
        }

        public aluno(int id, string nomeCompleto, int cpf, string email, string celular, bool whatsapp) : this(id, nomeCompleto, cpf, celular, whatsapp)
        {
            Email = email;
        }

        public aluno(int id, string nomeCompleto, int cpf, string email, int cep, string endereco, int endNumero, string bairro, string cidade, string estado) : this(id, nomeCompleto, cpf, email)
        {
            CEP = cep;
            Endereco = endereco;
            EndNumero = endNumero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public aluno(int id, string nomeCompleto, int cpf, string email, string celular, bool whatsapp, int cep, string endereco, int endNumero, string bairro, string cidade, string estado) : this(id, nomeCompleto, cpf, email, cep, endereco, endNumero, bairro, cidade, estado)
        {
            Celular = celular;
            Whatsapp = whatsapp;
        }
    }
}