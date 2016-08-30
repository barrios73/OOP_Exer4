using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4
{
    public class Customer
    {
        //attributes
        private string name;
        private string address;
        private string passportno;
        private DateTime dob;

        //constructor

        public Customer()
        {
            name = "NA";
            address = "NA";
            passportno = "NA";
            dob = new DateTime(1900, 01, 01);
        }

        public Customer(string CustName, string CustAddress, string ppNo, DateTime CustDOB): this ()
        {
            //Note that the parameter CustName is assigned to the property name 
            //It is not to the attribute name.  Therefore, the property method is
            //used for validation.  If the customer name is a single letter, it will be assigned
            //NA as written in the set method for the property Name.  If we have changed the line
            //code to name = CustName, no checking is done by the property method.  Whatever is
            //entered during the object creation is assigned to the attribute name  

            Name = CustName;
            address = CustAddress;
            passportno = ppNo;
            dob = CustDOB;
        }

        //property methods

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value.Length <= 1)
                    name = "Invalid customer name";
                else
                    name = value;
            }
        }
    }
}
