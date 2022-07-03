using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _2022_dodgelevel2_1_
{
    class Planet
    {// declare fields to use in the class 
        public int x, y, width, height;//variables for the rectangle 
        public Image planetImage;//variable for the planet's image

        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int score;
        //create a constructor (initailises the values of the fields)
        // methods for the planet class
        public void DrawPlanet(Graphics g)
        {
            planetRec = new Rectangle(x, y, width, height);
            g.DrawImage(planetImage, planetRec);    
        }
        public void MovePlanet()
        {

            planetRec.Location = new Point(x, y);
        }

        public Planet(int spacing)
        {
            //Create a constructor (initialises the values of the fields)
            x = spacing;
            y = 10;
            width = 20;
            height = 20;
            //planet image contains the plane1.png image
            planetImage = Properties.Resources.planet1;
            planetRec = new Rectangle(x, y, width, height);

        }

    }
}
   