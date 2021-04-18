using System;
using System.Collections;
using System.Collections.Generic;
using AromaBuffet.Models.Buffet.Evento;
using AromaBuffet.Models.Buffet.TipoCliente;

namespace AromaBuffet.Models.Buffet.Cliente
{
    public class ClienteEntity
    {
        public Guid Id { get; private set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public TipoClienteEntity Tipo { get; }
        
        public string Cpf { get; set; }
        
        public DateTime Data_Nascimento { get; set; }
        
        public string Cnpj { get; set; }
        
        public string Rua { get; set; }
        
        public string Bairro { get; set; }
        
        public string Cidade { get; set; }
        
        public string Uf { get; set; }
        
        public string Numero { get; set; }
        
        public string Obs { get; set; }
        
        public DateTime Data_Insercao { get; private set; }
        
        public DateTime Data_Alteracao { get; set; }

        public ClienteEntity(Guid id, string nome, string email, TipoClienteEntity tipo, string cpf, DateTime dataNascimento, string rua, string bairro, string cidade, string uf, string numero, string obs = "")
        {
            Id = id;
            Nome = nome;
            Email = email;
            Tipo = tipo;
            Cpf = cpf;
            Data_Nascimento = dataNascimento;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Numero = numero;
            Obs = obs;
            Data_Insercao = new DateTime();
            Data_Alteracao = new DateTime();
        }
        
        public ClienteEntity(Guid id, string nome, string email, TipoClienteEntity tipo, string cnpj, string rua, string bairro, string cidade, string uf, string numero, string obs = "")
        {
            Id = id;
            Nome = nome;
            Email = email;
            Tipo = tipo;
            Cnpj = cnpj;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Numero = numero;
            Obs = obs;
            Data_Insercao = new DateTime();
            Data_Alteracao = new DateTime();
        }
        
    }
}