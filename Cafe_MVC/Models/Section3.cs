﻿using Microsoft.AspNetCore.Mvc;

namespace Cafe_MVC.Models
{
    public class Section3
    {
        public string Name { get; set; }
        public string Image { get; set; }



        //this is constructor (ctrl . keyboard)
        public Section3(string name, string image)
        {
            Name = name;
            Image = image;
        }
    }
}
