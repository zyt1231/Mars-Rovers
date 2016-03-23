using System;
using System.Collections;

namespace mars_rovers
{
    static class PlateauArea
    {
        static int area_x;
        static int area_y;
        static ArrayList roverList = new ArrayList();

        public static void setArea(int x, int y)
        {
            area_x = x;
            area_y = y;
        }

        public static void addRover(Rover r)
        {
            roverList.Add(r);
        }


        public static bool checkValid(int x, int y)
        {
            if (x >= 0 && y >= 0 && x <= area_x && y <= area_y)
            {
                return true;
            }
            else return false;
        }


        public static void getAllRovers()
        {
            string strTmp = "";
            foreach (Rover r in roverList)
            {
                strTmp += String.Format("{0} {1} {2} \n", r.position.position_x, r.position.position_y, r.position.position_heading);
            }
            Console.WriteLine("Expected Output:");
            Console.WriteLine(strTmp);
        }


    }
}
