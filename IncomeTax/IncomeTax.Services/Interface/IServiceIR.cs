namespace IncomeTax.Services.Interface
{
    public interface IServiceIR
    {
        decimal GetIR(decimal salary, decimal liquidIncome);
    }
}
