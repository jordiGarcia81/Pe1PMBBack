using PlaceMyBetOficial.Models;
using PlaceMyBetOficial.Models.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static PlaceMyBetOficial.Models.objects.Evento;

namespace PlaceMyBetOficial.Controllers
{
    [RoutePrefix("api/Eventos")]
    public class EventosController : ApiController
    {
        [Route("GetEvento"), HttpGet]
       
        public List<Evento> Get()// recuperar Todos los eventos AE5
        {
            EventoRepository eventoRepository = new EventoRepository();
            List<Evento> listEvento = eventoRepository.GetEvento();
            return listEvento;
        }
       [Route("GetEventoDTO"), HttpGet]
        
        public List<EventoDTO> GetEventoDTO()
        {
            EventoRepository eventoRepository = new EventoRepository();
            List<EventoDTO> eventos = eventoRepository.GetEventoDTO();
            return eventos;
        }

        [Route ("UpdateEventos"),HttpPut]
        public void Put(int id, string local, string visitante)
        {
            EventoRepository rep = new EventoRepository();
            rep.Put(id, local, visitante);
        }
        [Route("DeleteEventos"), HttpDelete]
       
        public void Delete(int id)
        {
            EventoRepository rep = new EventoRepository();
            rep.Delete(id);
        }
        [Route("GetEventoVisitante"), HttpGet]
        public Evento GetEventoVisitante(string visitante)
        {
            EventoRepository eventoRepository = new EventoRepository();
            Evento evento = eventoRepository.GetEventoVisitante(visitante);
            return evento;
        }
        [Route("GetEventoLocal"), HttpGet]
        public Evento GetEventoLocal(string local)
        {
            EventoRepository eventoRepository = new EventoRepository();
            Evento evento = eventoRepository.GetEventoLocal(local);
            return evento;
        }
        [Route("GetEventoVisitante"), HttpGet]
        public Evento GetEventoFecha(DateTime fecha)
        {
            EventoRepository eventoRepository = new EventoRepository();
            Evento evento = eventoRepository.GetEventoFecha(fecha);
            return evento;
        }
        [Route("InsertarEvento"), HttpPost]
        public void insert(Evento evento)
        {
            EventoRepository eventoRepository = new EventoRepository();

            eventoRepository.insert(evento);
        }

    }
   

}
    
