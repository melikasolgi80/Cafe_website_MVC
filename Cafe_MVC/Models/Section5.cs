namespace Cafe_MVC.Models
{
    public class Section5
    {

        public string Name { get; set; }
        public string Image { get; set; }



        //this is constructor (ctrl . keyboard)
        public Section5(string name, string image)
        {
            Name = name;
            Image = image;
        }
    }
}
