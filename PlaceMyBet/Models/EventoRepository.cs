using MySql.Data.MySqlClient;
using PlaceMyBetOficial.Models.objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using static PlaceMyBetOficial.Models.objects.Evento;

namespace PlaceMyBetOficial.Models
{
    public class EventoRepository
    {
    
    internal List<Evento> GetEvento()
    {
        
        List<Evento> eventos = new List<Evento>();
        using (PlaceMyBetContext context = new PlaceMyBetContext())
        {
            eventos = context.Eventos.ToList();
            Debug.WriteLine("eventos" + eventos.Count);
        }

        return eventos;
    }
        internal List<EventoDTO> GetEventoDTO()
        {

            List<EventoDTO> eventos = new List<EventoDTO>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.Eventos.Select(p => ToDTO(p)).ToList();
                Debug.WriteLine("eventos" + eventos.Count);
            }

            return eventos;
        }

        static EventoDTO ToDTO(Evento e)
        {
            return  new EventoDTO(e.Local, e.Visitante);
        }
        internal void Save(Evento evento)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();

            context.Eventos.Add(evento);
            context.SaveChanges();

        }

        internal void Put(int id, string local, string visitante)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Evento e;
            using (context)
            {
                e = context.Eventos.Single(b => b.EventoId == id);
                e.Local = local;
                e.Visitante = visitante;
                context.SaveChanges();
            }

        }

        internal void Delete(int id)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Evento e;
            using (context)
            {
                e = context.Eventos.Single(b => b.EventoId == id);
                context.Eventos.Remove(e);
                context.SaveChanges();
            }
        }
        internal Evento GetEventoVisitante(string visitante)
        {
            Evento evento;

            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                evento = context.Eventos
                     .Where(s => s.Visitante == visitante)
                     .FirstOrDefault();
            }
            return evento;

        }

        internal Evento GetEventoLocal(string local)
        {
            Evento evento;

            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                evento = context.Eventos
                     .Where(s => s.Local == local)
                     .FirstOrDefault();
            }
            return evento;

        }

        internal Evento GetEventoFecha(DateTime fecha)
        {
            Evento evento;

            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                evento = context.Eventos
                     .Where(s => s.Fecha == fecha)
                     .FirstOrDefault();
            }
            return evento;

        }
        public void insert(Evento evento)
        {
            PlaceMyBetContext db = new PlaceMyBetContext();



            db.Eventos.Add(evento);

            db.SaveChanges();


        }




    }
}