using System;
using AromaBuffet.Models.Buffet.Cliente;
using AromaBuffet.Models.Buffet.SituacaoEvento;
using AromaBuffet.Models.Buffet.TipoEvento;

namespace AromaBuffet.Models.Buffet.Evento
{
    public class EventoEntity
    {
        public Guid Id { get; private set; }
        
        public string Nome { get; set; }
        
        public TipoEventoEntity Tipo { get; set; }

        public string Descricao { get; set; }
        
        public DateTime Inicio { get; set; }
        
        public DateTime Termino { get; set; }

        public ClienteEntity Cliente { get; set; }
        
        public SituacaoEventoEntity Situacao { get; set; }
        
        public string Descricao_Local { get; set; }
        
        public string Rua { get; set; }
        
        public string Bairro { get; set; }
        
        public string Cidade { get; set; }
        
        public string Uf { get; set; }
        
        public string Numero { get; set; }
        
        public string Obs { get; set; }
        
        public DateTime Data_Insercao { get; private set; }
        
        public DateTime Data_Alteracao { get; set; }

        public EventoEntity(Guid id, string nome, TipoEventoEntity tipo, string descricao, DateTime inicio, 
                DateTime termino, ClienteEntity cliente, SituacaoEventoEntity situacao, string descricaoLocal, 
                string rua, string bairro, string cidade, string uf, string numero, string obs = "")
        {
            Id = new Guid();
            Nome = nome;
            Tipo = tipo;
            Descricao = descricao;
            Inicio = inicio;
            Termino = termino;
            Cliente = cliente;
            Situacao = situacao;
            Descricao_Local = descricaoLocal;
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