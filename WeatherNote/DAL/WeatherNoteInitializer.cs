using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherNote.DAL
{
    public class WeatherNoteInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WeatherNoteContext>
    {
        protected override void Seed(WeatherNoteContext context)
        {
            var Notes = new List<Models.WeatherNoteDetails>
            {
                new Models.WeatherNoteDetails{ WeatherDate = DateTime.Now, NoteText = "This is test text", TempInfo = "00:00 -> 11°, 03:00 -> 9°, 06:00 -> 8°, 09:00 -> 13°"},
                new Models.WeatherNoteDetails{ WeatherDate = DateTime.Now, NoteText = "This is test text", TempInfo = "00:00 -> 11°, 03:00 -> 9°, 06:00 -> 8°, 09:00 -> 13°"},
                new Models.WeatherNoteDetails{ WeatherDate = DateTime.Now, NoteText = "This is test text", TempInfo = "00:00 -> 11°, 03:00 -> 9°, 06:00 -> 8°, 09:00 -> 13°"},
                new Models.WeatherNoteDetails{ WeatherDate = DateTime.Now, NoteText = "This is test text", TempInfo = "00:00 -> 11°, 03:00 -> 9°, 06:00 -> 8°, 09:00 -> 13°"},
                new Models.WeatherNoteDetails{ WeatherDate = DateTime.Now, NoteText = "This is test text", TempInfo = "00:00 -> 11°, 03:00 -> 9°, 06:00 -> 8°, 09:00 -> 13°"}

            };
            Notes.ForEach(x => context.weatherNotes.Add(x));
            context.SaveChanges();
        }
    }
}