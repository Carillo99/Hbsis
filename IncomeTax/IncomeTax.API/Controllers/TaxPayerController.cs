using IncomeTax.Domain.Commands.Input;
using IncomeTax.Domain.Entities;
using IncomeTax.Domain.Enum;
using IncomeTax.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IncomeTax.API.Controllers
{
    public class TaxPayerController : BaseController
    {
        private readonly ITaxpayerRepository _TaxpayerRepository;

        public TaxPayerController(ITaxpayerRepository TaxpayerRepository)
        {
            _TaxpayerRepository = TaxpayerRepository;
        }

        [HttpGet]
        [Route("v1/tax-payer")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var taxpayer = _TaxpayerRepository.GetAll("TaxpayerIR,MinimumWage");

                return await Response(taxpayer, ETipoResponse.Sucess);
            }
            catch (Exception e)
            {
                return await Response(e.Message, ETipoResponse.Error);
            }
        }

        [HttpGet]
        [Route("v1/tax-payer/{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            try
            {
                if (id <= 0)
                    return await Response("obrigatorio informar o Id!", ETipoResponse.ErrorValidacao);

                var taxPaye = _TaxpayerRepository.GetById(id);

                if (taxPaye == null)
                    return await Response($"O id {id}, informado não existe na base de dados!", ETipoResponse.ErrorValidacao);

                return await Response(taxPaye, ETipoResponse.Sucess);
            }
            catch (Exception e)
            {
                return await Response(e.Message, ETipoResponse.Error);
            }
        }

        [HttpPost]
        [Route("v1/tax-payer")]
        public async Task<IActionResult> Post([FromBody] TaxpayerCommand model)
        {
            try
            {
                return await Response(_TaxpayerRepository.Add(new Taxpayer(model.CPF, model.Name, model.NumberDependents, model.GrossIncome)), ETipoResponse.Sucess);
            }
            catch (Exception e)
            {
                return await Response(e.Message, ETipoResponse.Error);
            }
        }
    }
}
