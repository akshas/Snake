using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Snake
{
    class Field
    {
        private static int width = 40;
        private static int height = 20;

        public int VerticalStart = 2;
        public int HorisontalStart = 5;

        public static int LeftBorder = 5;
        public static int TopBorder = 2;
        public static int RightBorder = LeftBorder + Field.width;
        public static int BottomBorder = TopBorder + Field.height;

        //public static System.Timers.Timer gameTimer = new System.Timers.Timer(2000);


        public Field()
        {
            Console.SetWindowSize(100, 30);
            Console.CursorVisible = false;

            GetNewFeed();
        }


        #region drowField
        public void drowField()
        {
            Console.SetCursorPosition(HorisontalStart, VerticalStart);
            for(int i = 0; i < width; i++)
            {
                if (i % 2 == 0)
                    Console.Write("+ ");

            }
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(HorisontalStart, VerticalStart);
                Console.WriteLine("+");
                Console.SetCursorPosition(HorisontalStart + width, VerticalStart);
                Console.WriteLine("+");
                VerticalStart++;
            }

            Console.SetCursorPosition(HorisontalStart, VerticalStart);

            for (int i = 0; i <= width; i++)
            {
                if (i % 2 == 0)
                    Console.Write("+");
                else
                    Console.Write(" ");
            }
        }
        #endregion

        public static void GetNewFeed ()
        {
            
            Feed futter = new Feed();

        }

    }
}
