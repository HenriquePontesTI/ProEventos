using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data;
using api.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class EventoController : ControllerBase
  {
    private readonly DataContext context;
    public EventoController(DataContext context)
    {
      this.context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
      return context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
      return context.Eventos.FirstOrDefault(evento => evento.Id == id);
    }
  }
}
