using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Kcal {  get; set; }
        public double Protein { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }

        Ingredient() { }
    }
}
