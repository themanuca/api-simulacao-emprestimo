using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Parcela
    {
        public int Id { get; set; }
        public int PropostaId { get; set; }
        public int Month { get; set; }
        public decimal Principal { get; set; }
        public decimal Interest { get; set; }
        public decimal Balance { get; set; }
        public Proposta Proposta { get; set; }
    }
}
