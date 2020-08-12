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
        public static Dictionary<string, int> Position { get; set; }
        public Feed ()
        {
            //Thread.Sleep(3000);

            PosX = rand.Next(Field.LeftBorder, Field.RightBorder);
            PosY = rand.Next(Field.TopBorder, Field.BottomBorder);

            Console.SetCursorPosition(PosX, PosY);
            Console.Write(ch);

            Feed.Position.Add("top", PosY);
            Feed.Position.Add("left", PosX);

        }
        //public void GetPosition()
        //{
        //}
    }
}
