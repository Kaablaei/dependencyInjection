using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depedenci
{
    public class UserManager
    {
        private readonly ISendEmail _send;
        public UserManager(ISendEmail send)
        {
            _send = send;
        }



        public string ActiveAccount()
        {
            return _send.SendEmail();
        }
        public string UpdateAccount()
        {
            return _send.SendEmail();
        }
    }
}
