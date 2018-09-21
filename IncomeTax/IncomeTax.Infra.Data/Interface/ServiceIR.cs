using IncomeTax.Services.Interface;

namespace IncomeTax.Infra.Data.Interface
{
    public class ServiceIR : IServiceIR
    {
        public decimal GetIR(decimal salary, decimal liquidIncome)
        {
            return (salary * liquidIncome)/100;
        }
    }
}
