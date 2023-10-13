using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardFood.Core.Entities
{
    public class Restaurante : GuardFoodCommon
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Logo { get; set; }
        public string CorPrimaria { get; set; }
        public string CorSecundaria { get; set; }
    }
}
