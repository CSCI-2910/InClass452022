using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _452022
{
    internal class Class
    {
        public List<Person> People { get; set; } = new List<Person>();
        public string Title { get; set; }
        public int Number { get; set; }
        public Major Major { get; set; }

        public int SomethingElse { get; set; }

        public Class()
        {
            SomethingElse = 10;
        }

        public Class(int number)
        {
            SomethingElse = 30;
        }
    }
}
