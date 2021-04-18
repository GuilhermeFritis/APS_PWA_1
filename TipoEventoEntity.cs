using System;
using System.Collections.Generic;
using AromaBuffet.Models.Buffet.Evento;

namespace AromaBuffet.Models.Buffet.TipoEvento
{
    public class TipoEventoEntity
    {
        public Guid Id { get; private set; }
        public string Descricao { get; set; }
        
        public TipoEventoEntity(string descricao)
        {
            Id = new Guid();
            Descricao = descricao;
        } 
    }
}