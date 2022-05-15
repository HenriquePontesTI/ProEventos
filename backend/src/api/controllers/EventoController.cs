using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class EventoController : ControllerBase
  {
    public EventoController()
    {
    }

    public IEnumerable<Evento> _eventos = new List<Evento>(){
      new Evento()
      {
        Id = 1,
        Tema = "Test",
        Local = "Casa",
        Data = DateTime.Now.AddMonths(1).ToString(),
        Lote = "1º Lote",
        QtdPessoas = 20,

      },
      new Evento()
      {
        Id = 2,
        Tema = "Test 2",
        Local = "Casa 2",
        Data = DateTime.Now.AddMonths(2).ToString(),
        Lote = "2º Lote",
        QtdPessoas = 30,

      }
    };

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
      return _eventos;
    }
  }
}
