using System;
using System.Collections.Generic;
using AromaBuffet.Models.Buffet.Evento;

namespace AromaBuffet.Models.Buffet.TipoCliente
{
    public class TipoClienteEntity
    {
        public Guid Id { get; private set; }
        public string Descricao { get; set; }
        
        public TipoClienteEntity(string descricao)
        {
            Id = new Guid();
            Descricao = descricao;
        } 
    }
}