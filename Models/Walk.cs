

namespace DogGoMVC2.Models
   
{
    public class Walks
    {
        public int Id { get; set; }
       
        public string Date { get; set; }
        public int Duration { get; set; }

        public int WalkId { get; set; } 

        public int DogId { get; set; }  
    }
}
