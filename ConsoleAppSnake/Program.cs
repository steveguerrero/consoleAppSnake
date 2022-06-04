namespace ConsoleAppSnake
{
    internal class Program
    {
        static string[] gameField = generateGameField(6);

        //static string[,] gameField = new string[,] { { " ", " ", " " },
        //{ " ", " ", " " } };
        static string snk = "[-]";

        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            
            int posX = 0;
            //int posY = 0;
            //gameField[cntX,cntY] = snk;
            gameField[posX] = snk;
            refreshDisplay();
            ConsoleKeyInfo key;
            
            while (true)
            {
                    if (posX >= gameField.Length)
                        posX = 0;

                //    Thread.Sleep(500);
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.RightArrow)
                {
                    posX++; 
                    clearStepBefore(posX, 0);
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    posX--;
                    clearStepBefore(posX, 1);
                }
                gameField[posX] = snk;
                refreshDisplay();

            //    //cntX++;
            //    //cntY++;

            }

            Console.ReadLine();

        }
        static void refreshDisplay()
        {
            Console.Clear();
            for (int i = 0; i < gameField.Length; i++)
            {
                Console.Write(gameField[i]);
            }

        }
        static void clearStepBefore(int pos, int dir)
        {
            switch (dir)
            {
                case 0:
                    gameField[pos-1] = " ";
                    break;
                case 1:
                    gameField[pos+1] = " ";
                    break;
                default:
                    break;
            }
        }
        static string[] generateGameField(int cells)
        {
            string[] field = new string[cells];
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = " ";
            }
            return field;
        }
    }
}