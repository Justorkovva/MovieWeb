using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        //bo inaczej bierze normalnie z bazy i nie ma spacji
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        // jeśli nie będzie zgodny z moją datą z bazy to zmienić typ
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        // bez tego tez działa, ale do mapowania lepsze
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
