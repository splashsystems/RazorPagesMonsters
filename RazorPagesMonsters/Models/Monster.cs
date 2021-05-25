using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMonsters.Models
{
    public class Monster
    {
        public int ID { get; set; }
        public string MonsterName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date Introduced")]
        public DateTime YearPopularized { get; set; }
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Price { get; set; }
    }
}
