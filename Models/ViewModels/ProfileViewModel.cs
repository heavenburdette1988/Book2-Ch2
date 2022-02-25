using System.Collections.Generic;
using System;


namespace DogGoMVC2.Models.ViewModels
{
    //for Profile views infor for profile
    public class ProfileViewModel
    {
           
            public Owner Owner { get; set; }
            public List<Walker> Walkers { get; set; }
            public List<Dog> Dogs { get; set; }
        }
    }

