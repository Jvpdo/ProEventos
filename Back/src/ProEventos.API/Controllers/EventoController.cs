using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
    
        private readonly DataContext _Context;

        public EventoController(DataContext Context)
        {
            _Context = Context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _Context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _Context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }
        [HttpPost]
        public string Post()
        {
            return "value";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"value = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"value = {id}";
        }
    }
}
