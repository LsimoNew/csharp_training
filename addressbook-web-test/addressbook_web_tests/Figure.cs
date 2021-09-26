using System;
using System.Collections.Generic;
using System.Text;

namespace addressbook_web_tests
{
    class Figure
    {
        private bool colored = false;
        public bool Colored
        {
            get
            {
                return colored;
            }
            set
            {
                colored = value;
            }
        }
    }
}
