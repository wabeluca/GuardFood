using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardFood.Core.Entities
{
    public class Pedido : GuardFoodCommon
    {
        public string Descricao { get; set; }
        public string Localizacao { get; set; }
        
        [NotMapped]
        public string Usuario { get; set; }
    }
}
