using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterTaskConsoleApp
{
    internal class Printer {
    
         public string Name { get; set; }
        int LArkuszy = 0;

        public void PaperCount(string n, int la)
        {
            get 
                { 
                    
                }

            set 
                { 
                    Name = n;
                if (la >= 0)
                {
                    LArkuszy = la;
                }
                }
        }
        
    }
}
