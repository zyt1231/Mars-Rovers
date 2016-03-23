using System;


namespace mars_rovers
{
    class Position
    {
        public int position_x;
        public int position_y;
        public String position_heading;
        public Position(int x, int y, String h)
        {
            position_x = x;
            position_y = y;
            position_heading = h;
        }
    }
}
