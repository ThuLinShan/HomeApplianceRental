using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceRental
{
    class FormProvider
    {
        public static Login login
        {
            get
            {
                if (_login == null)
                {
                    _login = new Login();
                }
                return _login;
            }
        }
        private static Login _login;
    }
}

