using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{
    internal class Snake
    {
        int size;
        //int lifes;
        //int actualDirection;
        public Snake()
        {
            this.size = 1;
        }
        public int getSize()
        {
            return this.size;
        }
        public void getBigger()
        {
            this.size++;
        }
    }
}
