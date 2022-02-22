namespace DogGoMVC2.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string  Email { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public int NeighborhoodId { get; set; }
        //Why do we need N.ID
        public string Phone { get; set; }
        public Neighborhood Neighborhood { get; set; }
    }
}
