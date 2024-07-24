using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Amud
{
    public class Pillar
    {
       
        public float _height { get; set; }
           
        public float _width { get; set; }

        public string _place { get; set; }



        // בנאי
        
        public Pillar(float height, float width, string place)
        {
            _height = height;
            _width = width;
            _place = place;
        }

        public string GetStatus()
        {
            if(_height>0 && _width > 0)
            {

            switch (_place)
            {
                case "רשות היחיד":
                    return "רשות היחיד";

                case "כרמלית":
                    if (_height < 10)
                    return "כרמלית";
                    else if (_height >= 10 && _width >= 4)
                    return "רשות היחיד";
                    else if (_height >= 10 && _width < 4)
                    return "לפי רש''י: מקום פטור. לפי הטור: כרמלית";
                    break;

                case "רשות הרבים":
                    if (_height < 3 || _height >= 9 && _height < 10 && _width > 4)
                    return "רשות הרבים"; 
                    else if (_width < 4 && _height > 3)
                    return "מקום פטור"; 
                    else if (_width >= 4 && _height >= 3 && _height < 9)
                    return "כרמלית";
                    else if (_width >= 4 && _height <= 10)
                    return "רשות היחיד";
                    break;
                    }
            }
            else return "נא להכניס ערך ממשי";
            return "";






            


        }
    }
}
