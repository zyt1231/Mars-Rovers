using System;


namespace mars_rovers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Input 'SUBMIT' to get result****");
            Console.WriteLine("Test input:");

            //input area size
            Parser p = new Parser(Console.ReadLine());
            int number;
            while ((p.cTmp.Length != 2) || !(int.TryParse(p.cTmp[0], out number)) || !(int.TryParse(p.cTmp[1], out number)))
            {
                Console.WriteLine("Not valid input. Please retype area size:");
                p.parse(Console.ReadLine());
            }

            //create area
            PlateauArea.setArea(Convert.ToInt32(p.cTmp[0]), Convert.ToInt32(p.cTmp[1]));

            //input (x,y,heading)
            start:
            while (p.cTmp[0] != "SUBMIT")//input "submit" to get result
            {
                try
                {

                    p.parse(Console.ReadLine());
                    //create an Rover with position and heading
                    Rover rover1 = new Rover(new Position(Convert.ToInt32(p.cTmp[0]), Convert.ToInt32(p.cTmp[1]), Convert.ToString(p.cTmp[2])));
                    PlateauArea.addRover(rover1);//add this rover to area

                    p.parse(Console.ReadLine());//get action instructions
                    foreach (char c in p.cTmp[0])
                    {
                        if (c != 'R' && c != 'L' && c != 'M')
                        {
                            Console.WriteLine("Not valid input. Please retype area size:");
                            goto start;
                        }
                        rover1.turn(c.ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(" Not valid input. Please input Rover`s location (x y heading): ");
                    Console.WriteLine(e.ToString());
                }

            }
            PlateauArea.getAllRovers();

            Console.Read();
        }
    }
}

