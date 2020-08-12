using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Snake
{
    class Feed
    {
        private int PosX;
        private int PosY;
        char ch = 'o';
        Random rand = new Random();
        public static Dictionary<string, int> Position = new Dictionary<string, int>(2);
        public Feed ()
        {
            //Thread.Sleep(3000);

            PosX = rand.Next(Field.LeftBorder, Field.RightBorder);
            PosY = rand.Next(Field.TopBorder, Field.BottomBorder);
            Console.SetCursorPosition(PosX, PosY);
            Console.Write(ch);
            Position["top"] = PosY;
            Position["left"]  = PosX;

        }
        //public void GetPosition()
        //{
        //}
    }
}
