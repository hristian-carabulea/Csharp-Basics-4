using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics_4
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad.");
        }

        // public void MakeSpecialDish() 
        public virtual void MakeSpecialDish() // using virtual allows this method to be overridden in any sub-class of Chef.
        {
            Console.WriteLine("The chef makes BBQ Ribs.");
        }
    }
}
