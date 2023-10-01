using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardFood.Core.Entities
{
    public class Produto : GuardFoodCommon
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
