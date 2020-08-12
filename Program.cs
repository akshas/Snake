using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Field GameField = new Field();
            GameField.drowField();

            Snake gulja = new Snake();
            gulja.Move();


            



            Console.SetCursorPosition(0, 28);
        }
    }
}
