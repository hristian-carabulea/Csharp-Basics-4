using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics_4
{
    class ItalianChef : Chef  // ItalianCheff class inherits everything from the Chef class
    {
        // using override allows this method from the super-class to be overwritten in this sub-class, ItalianChef.
        // must use "virtual" for this method in the super-class, Chef.
        public override void MakeSpecialDish() 
        {
            Console.WriteLine("The Italian Chef makes Fish a la Venezia. (declared override in super-class)");
        }
        public void MakePizza()
        {
            Console.WriteLine ("The Italian Chef makes pizza, too.");
        }
    }
}
