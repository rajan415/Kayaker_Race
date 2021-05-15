using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kayaker_Race
{
 public  static class Factory

    {
     public static Guy GetBettorInfo(int ID)
     {
         switch (ID)
         {
                case 0:
                    return new Steve();

                case 1:
                    return new Allan();

                case 2:
                 return new Dax();
                default:
                    return new Steve();

         }
            //this initiates a new steve,dax or allan to hold the data from other classes.
              
     }
    }
}
