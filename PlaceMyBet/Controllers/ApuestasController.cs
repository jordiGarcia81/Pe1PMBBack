using PlaceMyBetOficial.Models;
using PlaceMyBetOficial.Models.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static PlaceMyBetOficial.Models.objects.Apuesta;
//using static PlaceMyBetOficial.Models.objects.ResponseData;

namespace PlaceMyBetOficial.Controllers
{
    [RoutePrefix("api/Apuestas")]
    public class ApuestasController : ApiController
    {
        //private PlaceMyBetContext db = new PlaceMyBetContext();
        [Route("GetApuestas"), HttpGet]
       
        public List<Apuesta> GetApuestas()// recuperar todas las apuestas AE5
        {
            ApuestaRepository apuestaRepository = new ApuestaRepository();
            List<Apuesta> listApuesta = apuestaRepository.GetApuestas();
            return listApuesta;
        }
        //[Route("api/GetApuestasMercado")]
        //[HttpGet]
        //public List<Apuesta> GetApuestasMercado()
        //{
        //    ApuestaRepository apuestaRepository = new ApuestaRepository();
        //    List<Apuesta> listApuesta = apuestaRepository.GetApuestasMercado();
        //    return listApuesta;
        //}
        [Route("GetApuestaId"), HttpPost]
        
        public Apuesta GetApuestaId(int id)// recuperar todas las apuestas  partir de un Id AE5
        {
            ApuestaRepository apuestaRepository = new ApuestaRepository();
            Apuesta apuesta = apuestaRepository.GetApuestaId(id);
            return apuesta;
        }

        
        [Route("InsertarApuestas"), HttpPost]
        public bool Insertar(Apuesta apuesta)
        {
            ApuestaRepository apuestaRepository = new ApuestaRepository();
            if (!apuestaRepository.Insertar(apuesta)) return false;

            return true;
        }
        [Route("GetApuestaDTO"), HttpGet]
       
        public List<ApuestaDTO> GetApuestaDTO()
        {
            ApuestaRepository apuestaRepository = new ApuestaRepository();
            List<ApuestaDTO> listApuesta = apuestaRepository.GetApuestaDTO();
            return listApuesta;
        }
        [Route("GetApuestaEmail"), HttpGet]
        public Apuesta GetApuestaEmail(string email)
        {
            ApuestaRepository apuestaRepository = new ApuestaRepository();
            Apuesta apuesta = apuestaRepository.GetApuestaEmail(email);
            return apuesta;
        }
        [Route("GetMercadoId"), HttpGet]
        public Apuesta GetMercadoId(int mercado)
        {
            ApuestaRepository apuestaRepository = new ApuestaRepository();
            Apuesta apuesta = apuestaRepository.GetMercadoId(mercado);
            return apuesta;
        }

    }
}
