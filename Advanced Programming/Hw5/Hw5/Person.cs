using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
    public class Person
    {

        public String name, surname, email, city, gender;
        public long phoneNumber;
        public int age;
        public System.Drawing.Image img;
      
        public override string ToString()
        { 
            return this.name+ " " + this.surname;
        }
    }
    
}
