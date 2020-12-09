using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Overlaoding
    {
        public int Add(int x , int y)
        {
            int res = x + y;
            return res;
        }
        public int Add(int x, int y , int c)
        {
            int res = x + y + c;
            return res;
        }
        public float Add(float x, float y)
        {
            float res = x * y;
            return res;
        }
    }
}
