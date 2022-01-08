﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly ILogger<EventoController> _logger;

        public EventoController()
        {
        }

        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .Net5",
                Local = "Belo Horizonte",
                Lote = "1 Lote",
                QtdePessoas = 250,
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyy"),
                ImagemURL = "goto.png"
            },
            new Evento(){
                EventoId = 2,
                Tema = "Entity Framework",
                Local = "Salvador",
                Lote = "2 Lote",
                QtdePessoas = 100,
                DataEvento = DateTime.Now.AddDays(10).ToString("dd/MM/yyy"),
                ImagemURL = "goto.png"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(x => x.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return "Exemplo de put com id = " + id;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return "Exemplo de delete com id = " + id;
        }
    }
}
