using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DTO
{
    public class ValorEntradaDTO
    {
        public decimal LoanAmount { get; set; }
        public float AnnualInterestRate { get; set; }
        public int NumberOfMoths { get; set; }
    }
}
