using System;
using System.Collections.Generic;
using AromaBuffet.Models.Buffet.Evento;

namespace AromaBuffet.Models.Buffet.SituacaoConvidado
{
    public class SituacaoConvidadoEntity
    {
        public Guid Id { get; private set; }
        public string Descricao { get; set; }
        
        public SituacaoConvidadoEntity(string descricao)
        {
            Id = new Guid();
            Descricao = descricao;
        } 
    }
}