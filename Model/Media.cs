using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music.Model
{
    internal enum MusicCategory
    {
       Instruments,
       Kids
    }
    internal class Media
    {
       
       public string Name { get; set; }

       public string ImageFile { get; set; }
       
       public string MediaFile { get; set; } 
        public MusicCategory Category { get; set; }

        public Media(string name, MusicCategory category)
        {
            Name = name;
            Category = category;
            MediaFile = $"/Assets/MusicFile/{category}/{name}.mp3";
            ImageFile = $"/Assets/Images/{category}/{name}.png";

        }


    }
  
}
