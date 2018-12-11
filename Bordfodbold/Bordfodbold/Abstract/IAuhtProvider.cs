using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bordfodbold.Abstract {
   public interface IAuhtProvider {

        bool Authenticate(string Username, string Password);
            
        
    }
}
