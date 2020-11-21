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
            mapNumber = 0;
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
                mapImage = Resources.Map_Customs;
            }
            else if (map == 2) // Factory
            {
                mapImage = Resources.Map_Factory;
            }
            else if (map == 3) // Interchange
            {
                mapImage = Resources.Map_Interchange;
            }
            else if (map == 4) // Reserve
            {
                mapImage = Resources.Map_Reserve;
            }
            else if (map == 5) // Shoreline
            {
                mapImage = Resources.Map_Shoreline;
            }
            else if (map == 6) // The Lab
            {
                mapImage = Resources.Map_TheLab;
            }
            else if (map == 7) // Woods
            {
                mapImage = Resources.Map_Woods;
            }
            else mapImage = null;
            return mapImage;
        }
    }
}
