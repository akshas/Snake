using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Snake
{
    class Snake
    {
        char Zeichen = 'x';
        int PosX;
        int PosY;
        int direction;
        public static int FoodCounter = 0;
        public static Dictionary<string, int> Position = new Dictionary<string, int>(2); 
        Random rand = new Random();
        public delegate void DirectionHandler(string d);

        public static event DirectionHandler DirectionChangeActivated;


        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public Snake()
        {
            PosX = rand.Next(Field.LeftBorder, Field.RightBorder);
            PosY = rand.Next(Field.TopBorder, Field.BottomBorder);
            Console.SetCursorPosition(PosX, PosY);
            Console.Write(Zeichen);
            Position.Add("top", PosY);
            Position.Add("left", PosX);
        }

        #endregion


        #region ChangeDirection
        public void ChangeDirection(string s)
        {

            switch(s)
            {
                case "w":
                    Console.SetCursorPosition(0, 0);
                    direction = 1;
                    break;
                case "s":
                    Console.SetCursorPosition(0, 0);
                    direction = 2;
                    break;
                case "d":
                    Console.SetCursorPosition(0, 0);
                    direction = 4;
                    break;
                case "a":
                    Console.SetCursorPosition(0, 0);
                    direction = 3;
                    break;
            }
            Console.Write(" ");
        }

        #endregion


        #region Move
        public void Move ()
        {


            direction = rand.Next(1, 5);

            while (PosX != Field.LeftBorder && PosX != Field.RightBorder && PosY != Field.TopBorder && PosY != Field.BottomBorder)
            {
                if(Console.KeyAvailable)
                {
                    Console.SetCursorPosition(0, 0);
                    char key = Console.ReadKey().KeyChar;
                    DirectionChangeActivated += ChangeDirection;
                    DirectionChangeActivated?.Invoke(key.ToString());
                }

                Console.SetCursorPosition(PosX, PosY);
                Console.Write(" ");

                switch (direction)
                {
                    case 1:
                        PosY--;
                        break;
                    case 2:
                        PosY++;
                        break;
                    case 3:
                        PosX--;
                        break;
                    case 4:
                        PosX++;
                        break;
                }

                Console.SetCursorPosition(PosX, PosY);
                Console.WriteLine(Zeichen);
                Position["top"] = PosY;
                Position["left"] = PosX;
           if(Snake.Position["top"] == Feed.Position["top"] && Snake.Position["left"] == Feed.Position["left"] )
           {
                Field.GetNewFeed();
                FoodCounter++;
           } 
                Thread.Sleep(300);

            }
        }
        #endregion


        public void Eat()
        {
        }
    }
}
