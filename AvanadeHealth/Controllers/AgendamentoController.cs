using AvanadeHealth.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvanadeHealth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        [HttpGet]
        [Route("/ListarAgenda")]
        public IActionResult Get()
        {
            try
            {
                return Ok(new Agendamento());
            }
            catch (System.Exception)
            {
                return BadRequest("Erro ao tentar obter agendamento");
            }
        }

        [HttpPost]
        [Route("/CadastrarAgenda")]
        public IActionResult Post([FromBody] Agendamento agendamento)
        {
            try
            {
                return Ok(agendamento);
            }
            catch (System.Exception)
            {
                return BadRequest("Erro ao tentar cadastrar agendamento");
            }
        }

        [HttpPut]
        [Route("/AtualizarAgenda")]
        public IActionResult Put([FromBody] Agendamento agendamento)
        {
            try
            {
                return Ok(agendamento);
            }
            catch (System.Exception)
            {
                return BadRequest("Erro ao tentar atualizar agendamento");
            }
        }

        [HttpDelete]
        [Route("/DeletarAgenda")]
        public IActionResult Delete([FromBody] Agendamento agendamento)
        {
            try
            {
                return Ok(agendamento);
            }
            catch (System.Exception)
            {
                return BadRequest("Erro ao tentar deletar agendamento");
            }
        }

    }
}