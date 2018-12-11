using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Bordfodbold.Abstract;

namespace Bordfodbold.Concrete {
    public class FormAuthProvider : IAuhtProvider {
        public bool Authenticate(string Username, string Password) {
            bool result = FormsAuthentication.Authenticate(Username, Password);
            if (result) {
                FormsAuthentication.SetAuthCookie(Username, false);
            }
                return result;
        }

    }
}