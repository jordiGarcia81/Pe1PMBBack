using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBetOficial.Models.objects
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Visitante { get; set; }
        public string Local { get; set; }
        public DateTime Fecha { get; set; }
       // public Mercado Mercados { get; set; }
        public List<Mercado> Mercados { get; set; }

        public Evento(int eventoId, string visitante, string local, DateTime fecha)
        {
            this.EventoId = eventoId;
            this.Visitante = visitante;
            this.Local = local;
            this.Fecha = fecha;

        }
        
        
    }

    public class EventoDTO
    {
        public string Local { get; set; }
        public string Visitante { get; set; }

        public EventoDTO()
        {

        }
        public EventoDTO(string local, string visitante)
        {
            this.Local = local;
            this.Visitante = visitante;
            

        }

        
    }
}