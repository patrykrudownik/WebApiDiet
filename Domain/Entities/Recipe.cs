using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Recipe : Meal
    {
        public int Id { get; set; }
        public List<String> Steps { get; set; }
    }
}
