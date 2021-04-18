using System;
using AromaBuffet.Models.Buffet.Evento;
using AromaBuffet.Models.Buffet.SituacaoEvento;

namespace AromaBuffet.Models.Buffet.Convidado
{
    public class ConvidadoEntity
    {
        public Guid Id { get; private set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string Cpf { get; set; }
        
        public DateTime Data_Nascimento { get; set; }
        
        public EventoEntity Evento { get; set; }
        
        public SituacaoEventoEntity Situacao { get; set; }
        
        public string Obs { get; set; }
        
        public DateTime Data_Insercao { get; private set; }
        
        public DateTime Data_Alteracao { get; set; }

        public ConvidadoEntity(Guid id, string nome, string email, string cpf, DateTime dataNascimento, EventoEntity evento, SituacaoEventoEntity situacao, string obs = "")
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Data_Nascimento = dataNascimento;
            Evento = evento;
            Situacao = situacao;
            Obs = obs;
            Data_Insercao = new DateTime();
            Data_Alteracao = new DateTime();
        }
    }
}