using IncomeTax.Domain.Commands.Input;
using IncomeTax.Domain.Entities;
using IncomeTax.Domain.Enum;
using IncomeTax.Domain.Repository;
using IncomeTax.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IncomeTax.API.Controllers
{
    public class MinimumWageController : BaseController
    {
        private readonly IMinimumWageRepository _minimumWageRepository;
        private readonly ITaxpayerIRRepository _taxpayerIRRepository;
        private readonly ITaxpayerRepository _TaxpayerRepository;
        private readonly IContributionIR _contributionIR;

        public MinimumWageController(IMinimumWageRepository minimumWageRepository, ITaxpayerIRRepository taxpayerIRRepository, IContributionIR contributionIR, ITaxpayerRepository TaxpayerRepository)
        {
            _TaxpayerRepository = TaxpayerRepository;
            _taxpayerIRRepository = taxpayerIRRepository;
            _minimumWageRepository = minimumWageRepository;
            _contributionIR = contributionIR;
        }

        [HttpGet]
        [Route("v1/tax-payer/{taxpayerId:int}/minimum-wage")]
        public async Task<IActionResult> GetAll([FromRoute] int taxpayerId)
        {
            try
            {
                var minimumWage = _minimumWageRepository.GetAll();

                return await Response(minimumWage, ETipoResponse.Sucess);
            }
            catch (Exception e)
            {
                return await Response(e.Message, ETipoResponse.Error);
            }
        }

        [HttpGet]
        [Route("v1/Tax-payer/{taxpayerId:int}/minimum-wage/{id}")]
        public async Task<IActionResult> Get( int id, [FromRoute] int taxpayerId)
        {
            try
            {
                if (id <= 0)
                    return await Response("obrigatorio informar o Id!", ETipoResponse.ErrorValidacao);

                var minimumWage = _minimumWageRepository.GetById(id);

                if (minimumWage == null)
                    return await Response($"O id {id}, informado não existe na base de dados!", ETipoResponse.ErrorValidacao);

                return await Response(minimumWage, ETipoResponse.Sucess);
            }
            catch (Exception e)
            {
                return await Response(e.Message, ETipoResponse.Error);
            }
        }

        [HttpPost]
        [Route("v1/Tax-payer/{taxpayerId:int}/minimum-wage")]
        public async Task<IActionResult> Post([FromBody] MinimumWageCommand model, [FromRoute] int taxpayerId)
        {
            try
            {
                var taxpayer = _TaxpayerRepository.GetById(taxpayerId);
                
                _taxpayerIRRepository.Add(new TaxpayerIR(_contributionIR.LiquidIncome(taxpayer.GrossIncome, taxpayer.NumberDependents, model.MinimumWageBase), taxpayerId));
                return await Response(_minimumWageRepository.Add(new MinimumWage(model.MinimumWageBase, taxpayerId)), ETipoResponse.Sucess);
            }
            catch (Exception e)
            {
                return await Response(e.Message, ETipoResponse.Error);
            }
        }
    }
}
