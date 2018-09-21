using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeTax.Domain.Commands.Exits
{
    public class ResultComand
    {
        public ResultComand(object data, int totalRegistros)
        {
            Data = data;
            count = totalRegistros;
        }

        public object Data { get; set; }
        public int count { get; set; }
    }
}
