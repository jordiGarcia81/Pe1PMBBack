using PlaceMyBetOficial.Models;
using PlaceMyBetOficial.Models.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBetOficial.Controllers
{
    [RoutePrefix("api/Mercados")]
    public class MercadosController : ApiController
    {
        private PlaceMyBetContext db = new PlaceMyBetContext();

        [Route("GetMercados")]//recuperar todos los mercados
        [HttpGet]
        public List<Mercado> GetMercados()
        {
            MercadoRepository mercadoRepository = new MercadoRepository();
            List<Mercado> listmercado = mercadoRepository.GetMercados();
            return listmercado;
        }
        [Route("GetMercadosEvento")]//recuperar todos los mercados y eventos
        [HttpGet]
        public List<Mercado> GetMercadosEvento()
        {
            MercadoRepository mercadoRepository = new MercadoRepository();
            List<Mercado> listmercado = mercadoRepository.GetMercadosEvento();
            return listmercado;
        }

        [Route("GetMercadosDTO")]
        [HttpGet]
        public List<MercadoDTO> GetDTO()
        {
            MercadoRepository mercadoRepository = new MercadoRepository();
            List<MercadoDTO> listmercado = mercadoRepository.GetMercadosDTO();
            return listmercado;
        }
        [Route("GetMercadoId")]//recuperar todos los mercados a partir de un Id
        [HttpGet]
        public Mercado GetMercadoId(int id)
        {
            MercadoRepository mercadoRepository = new MercadoRepository();
            Mercado mercado = mercadoRepository.GetMercadoId(id);
            return mercado;
        }
        [Route("Insert")]
        [HttpPost]
        public void insert(Mercado mercado)
        {
            MercadoRepository mercadoRepository = new MercadoRepository();

           mercadoRepository.insert(mercado);
        }
    }
}
