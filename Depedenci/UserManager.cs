using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depedenci
{
    public class UserManager
    {
        ISendEmail send = new SendGmail();
        public string ActiveAccount()
        {
            return send.SendEmail();
        }
        public string UpdateAccount()
        {
            return send.SendEmail();
        }
    }
}