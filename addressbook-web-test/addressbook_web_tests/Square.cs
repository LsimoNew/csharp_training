using System;
using System.Collections.Generic;
using System.Text;

namespace addressbook_web_tests
{
    class Square : Figure
    {
        private int size;
        private bool colored = false;

        public Square(int size)
        {
            this.size = size;
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
    }
}
