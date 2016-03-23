using System;

namespace mars_rovers
{
    public enum heading
    {
        N, E, S, W
    };



    class Rover
    {
        public Position position;



        public Rover(Position p)
        {
            position = p;
            //Console.WriteLine( Enum.IsDefined(typeof(heading), p.position_heading));

        }



        public Position getPosition()
        {
            return this.position;
        }



        public void x_move(string heading)
        {

            switch (heading)
            {
                case "N":
                    //       Console.WriteLine("N");
                    break;
                case "S":
                    //       Console.WriteLine("S");
                    break;
                case "W":
                    //      Console.WriteLine("W");
                    if (PlateauArea.checkValid(position.position_x - 1, position.position_y))
                        position.position_x--;
                    else
                        Console.WriteLine("Move out of Plateau Area in X direction.");
                    break;
                case "E":
                    if (PlateauArea.checkValid(position.position_x + 1, position.position_y))
                        position.position_x++;
                    else
                        Console.WriteLine("Move out of Plateau Area in X direction.");
                    break;
                default:
                    Console.WriteLine("Not valid input.");
                    break;
            }
        }



        public void y_move(string heading)
        {

            switch (heading)
            {
                case "N":
                    if (PlateauArea.checkValid(position.position_x, position.position_y + 1))
                        position.position_y++;
                    else
                        Console.WriteLine("Move out of Plateau Area in Y direction.");
                    break;
                case "S":
                    //   Console.WriteLine("S");// move toward S

                    if (PlateauArea.checkValid(position.position_x, position.position_y - 1))
                        position.position_y--;
                    else
                        Console.WriteLine("Move out of Plateau Area in Y direction.");
                    break;
                case "W":
                    //  Console.WriteLine("W");

                    break;
                case "E":
                    //   Console.WriteLine("E");

                    break;
                default:
                    Console.WriteLine("Not valid input.");
                    break;
            }

        }


        public void turn(String str)
        {
            int tmpheadingNum = (int)(Enum.Parse(typeof(heading), position.position_heading));
            switch (str)
            {
                case "L":
                    tmpheadingNum = (4 + tmpheadingNum - 1) % 4;
                    position.position_heading = ((heading)tmpheadingNum).ToString();
                    break;
                case "R":
                    tmpheadingNum = (tmpheadingNum + 1) % 4;
                    position.position_heading = ((heading)tmpheadingNum).ToString();
                    break;
                case "M":
                    x_move(position.position_heading);
                    y_move(position.position_heading);
                    break;
                default:
                    Console.WriteLine("Not valid input.");
                    break;

            }
        }

        public Position getState()
        {
            return this.position;
        }
    }
}
