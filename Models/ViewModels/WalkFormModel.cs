using System.Collections.Generic;

namespace DogGoMVC2.Models.ViewModels
{

    //drop down menu for walks and dogs  
    //for ADD 
    public class WalkFormModel
    {

        public Walk Walk { get; set; }
        public List<Walker> Walkers { get; set; }
        public List<Dog> Dogs { get; set; }
    }
}
