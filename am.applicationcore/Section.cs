using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Section
    {
        [Key]
        public int IdSection { get; set; }

        [StringLength(1), Required(ErrorMessage = "isRequired")]
        public string? Name { get; set; }
        public virtual List<Seat> Seats { get; set; }
    }
}
