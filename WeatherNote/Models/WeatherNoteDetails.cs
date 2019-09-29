using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeatherNote.Models
{
    public class WeatherNoteDetails
    {
        [Key]
        public int WeatherNoteId { get; set; }
        public DateTime WeatherDate { get; set; }
        public string NoteText { get; set; }
        public string TempInfo { get; set; }
    }
}