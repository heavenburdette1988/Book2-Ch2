using System.Collections.Generic;

namespace DogGoMVC2.Models.ViewModels
{    

        public class WalkersProfileViewModel
        {
            public Walker Walker { get; set; }
        //includes NHood Model inside walker class
            public List<Walk> Walks { get; set; }
        }
    }

