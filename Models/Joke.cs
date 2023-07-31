using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace JokesWebApp.Models
{
    public class Joke
    {

        public int Id { get; set; }
        public string JokeQuesiton  { get; set; }
        public string JokeAnswer{ get; set; }

        public Joke()
        {
            
        }
    }
}
