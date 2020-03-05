using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        // Create variables for model
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Display(Name = "Book")]
        public string BookModels { get; set; }
             
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Note { get; set; }
    }
}
