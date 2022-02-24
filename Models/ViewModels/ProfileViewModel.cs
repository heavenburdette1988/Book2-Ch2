using System.Collections.Generic;
using System;
using DogGoMVC2.Models;

namespace DogGoMVC2.Models.ViewModels
{
    public class ProfileViewModel
    {
 
            public Owner Owner { get; set; }
            public List<Walker> Walkers { get; set; }
            public List<Dog> Dogs { get; set; }
        }
    }

