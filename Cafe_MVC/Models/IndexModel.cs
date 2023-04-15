using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Cafe_MVC.Models
{ 
    public class IndexModel
    {
           public List<Section2> Section2s { get; set;}
        public List<Section3> Options { get;}
    }
}
