using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Cafe_MVC.Models
{ 
    public class IndexModel
    {
        public List<Section2> Section2s { get;}
        public List<Section3> Section3s { get; }
        public List<Section4> Section4s { get; }
        public List<Section5> Section5s { get; }
    }
}
