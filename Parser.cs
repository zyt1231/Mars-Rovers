using System;


namespace mars_rovers
{
    class Parser
    {
        public string[] cTmp;


        public Parser(String str)
        {
            try
            {
                cTmp = str.Trim().ToUpper().Split(new char[] { ' ' });
               // Console.WriteLine(cTmp.Length);
            }
            catch
            {
                Console.WriteLine("Error...");
            }
        }

        public void parse(string str)
        {
            cTmp = str.Trim().ToUpper().Split(new char[] { ' ' });
          //  Console.WriteLine(cTmp.Length);
        }
     
    }
}
