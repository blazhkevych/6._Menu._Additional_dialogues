using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Authors
    {
        public string Name { get; set; } = "Some name";

        // Author's book list.
        public List<Books> BooksList ;

        // Constructor.
        public Authors(string name)
        {
            Name = name;
            BooksList = new List<Books>();
        }
    }
}
