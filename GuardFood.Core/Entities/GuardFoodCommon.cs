using System.ComponentModel.DataAnnotations;


namespace GuardFood.Core.Entities
{
    public class GuardFoodCommon
    {
        [Key]
        public Guid Id { get; set; } 
        public DateTime Inclusao { get; set; }
        public DateTime Alteracao { get; set; }
    }
}
