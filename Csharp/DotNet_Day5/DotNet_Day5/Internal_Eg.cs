using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day5
{
    class Internal_Eg
    {
        public void Access_InternalMembers()
        {

            // here we are tring to use the fields in the AccessSpecifer_Eg class so we need to create a object of tht class because there are non static 
            AccessSpecifier_Eg ag2 = new AccessSpecifier_Eg(); // object created tht is ag2
            ag2.Sname = "harsha"; //we can access Sname field because it is public
            ag2.Marks = 80; // we can use marks field because it is internal(only inside assembly in any class)
            


        }
    }
}
