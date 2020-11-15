using EscapeFromTarkovLoadout.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTarkovLoadout
{
    public class Maps
    {
        // 7 maps in patch 0.12.8.97.67
        //https://escapefromtarkov.gamepedia.com/Map_of_Tarkov

        int mapNumber; // Local varibale for storing the random generaten map number

        // Generates random number between 1-7, there are 7 bifrent maps
        public int RandomMap()
        {
            Random rnd = new Random();
            int map = rnd.Next(1, 8); // Uses last number, therefore it's 8
            return map;
        }

        // Calling RandomMap and saved the number in local varibale in usage for image
        public void GetRandomMap()
        {
            mapNumber = RandomMap();
        }

        // Getting the random number from local variable mapNumber and setting a image for it
        public Image GetMapImage()
        {
            Image mapImage;
            int map;
            map = mapNumber;

            if (map == 1) // Customs
            {
                //mapImage = Resources
                mapImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Maps\Customs.png");
            }
            else if (map == 2) // Factory
            {
                mapImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Maps\Factory.png");
            }
            else if (map == 3) // Interchange
            {
                mapImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Maps\Interchange.png");
            }
            else if (map == 4) // Reserve
            {
                mapImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Maps\Reserve.png");
            }
            else if (map == 5) // Shoreline
            {
                mapImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Maps\Shoreline.png");
            }
            else if (map == 6) // The Lab
            {
                mapImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Maps\TheLab.png");
            }
            else if (map == 7) // Woods
            {
                mapImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Maps\Woods.png");
            }
            else mapImage = null;
            return mapImage;
        }
    }
}
