using System;
using System.Collections.Generic;
using AromaBuffet.Models.Buffet.Evento;

namespace AromaBuffet.Models.Buffet.SituacaoEvento
{
    public class SituacaoEventoEntity
    {
        public Guid Id { get; private set;}
        public string Descricao { get; set; }
        
        public SituacaoEventoEntity(string descricao)
        {
            Id = new Guid();
            Descricao = descricao;
        } 
    }
}