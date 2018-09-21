using IncomeTax.Domain.Commands.Input;
using IncomeTax.Domain.Entities;
using IncomeTax.Domain.Enum;
using IncomeTax.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IncomeTax.API.Controllers
{
    public class TaxpayerIRController : BaseController
    {
        private readonly ITaxpayerIRRepository _taxpayerIRRepository;

        public TaxpayerIRController(ITaxpayerIRRepository taxpayerIRRepository)
        {
            _taxpayerIRRepository = taxpayerIRRepository;
        }

        [HttpGet]
        [Route("v1/Tax-payer/{taxpayerId:int}/Tax-payer-ir/{id}")]
        public async Task<IActionResult> Get([FromRoute] int id, [FromRoute] int taxpayerId)
        {
            try
            {
                if (id <= 0)
                    return await Response("obrigatorio informar o Id!", ETipoResponse.ErrorValidacao);

                var taxPayeIR = _taxpayerIRRepository.GetById(id);

                if (taxPayeIR == null)
                    return await Response($"O id {id}, informado não existe na base de dados!", ETipoResponse.ErrorValidacao);

                return await Response(taxPayeIR, ETipoResponse.Sucess);
            }
            catch (Exception e)
            {
                return await Response(e.Message, ETipoResponse.Error);
            }
        }

        [HttpPost]
        [Route("v1/Tax-payer/{taxpayerId:int}/Tax-payer-ir")]
        public async Task<IActionResult> Post([FromBody] TaxpayerIRCommand model, [FromRoute] int taxpayerId)
        {
            try
            {
                return await Response(_taxpayerIRRepository.Add(new TaxpayerIR(model.IR, taxpayerId)), ETipoResponse.Sucess);
            }
            catch (Exception e)
            {
                return await Response(e.Message, ETipoResponse.Error);
            }
        }
    }
}
