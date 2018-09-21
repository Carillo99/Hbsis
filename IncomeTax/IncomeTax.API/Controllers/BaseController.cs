using IncomeTax.Domain.Commands.Exits;
using IncomeTax.Domain.Enum;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IncomeTax.API.Controllers
{
    [ProducesResponseType(typeof(object), 200)]
    [ProducesResponseType(typeof(ResponseSucesso), 200)]
    [ProducesResponseType(typeof(ResultComand), 200)]
    [ProducesResponseType(typeof(object), 201)]
    [ProducesResponseType(typeof(ResponseValidacao), 400)]
    [ProducesResponseType(typeof(void), 404)]
    [ProducesResponseType(typeof(void), 401)]
    [ProducesResponseType(typeof(ResponseErro), 500)]
    public class BaseController : Controller
    {
        protected BaseController(){ }

        /// <summary>
        /// Metodo para retornar o response para o tipo certo
        /// </summary>
        /// <param name="result">objeto contedo o valor de deseja que retorne</param>
        /// <param name="tipoResponse">tipo do response(200 e 201)</param>
        /// <returns></returns>
        public async Task<IActionResult> Response(object result, ETipoResponse tipoResponse)
        {

            switch (tipoResponse)
            {
                case ETipoResponse.Sucess:
                    return Ok(result);
                case ETipoResponse.Create:
                    return StatusCode(201, result);

                default:
                    return Ok(result);
            }
        }

        public async Task<IActionResult> Response(string message, ETipoResponse tipoResponse)
        {
            switch (tipoResponse)
            {
                case ETipoResponse.ErrorValidacao:
                    return BadRequest(new ResponseValidacao(message));
                case ETipoResponse.Error:
                    return StatusCode(500, new ResponseErro(message));
                case ETipoResponse.Sucess:
                    return Ok(new ResponseSucesso(message));
                default:
                    return Ok(message);
            }
        }
    }

    /// <summary>
    /// Class responsavel para retornar a message de error
    /// </summary>
    public class ResponseErro
    {
        /// <summary>
        /// Construtor da class
        /// </summary>
        /// <param name="erro">messagem com o erro</param>
        public ResponseErro(string erro)
        {
            Erro = erro;
        }

        public string Erro { get; protected set; }
    }

    public class ResponseValidacao
    {
        public ResponseValidacao(string message)
        {
            Message = message;
        }

        public string Message { get; protected set; }
    }

    public class ResponseSucesso
    {
        public ResponseSucesso(string message)
        {
            Message = message;
        }

        public string Message { get; protected set; }
    }
}

