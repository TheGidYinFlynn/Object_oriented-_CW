using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    class Guest
    {
        private string fullName;
        private string passportNumber;
        private int bookingId;


        public string Name
        {
            get
            {
                return fullName;

            }

            set
            {
                fullName = value;
            }


        }

        public String passport
        {
            get
            {
                return passportNumber;

            }

            set
            {
                passportNumber = value;

            }

          
        }
        
        public int id
        {
            get
            {
                return bookingId;
            }

            
        }
    }
}
    
