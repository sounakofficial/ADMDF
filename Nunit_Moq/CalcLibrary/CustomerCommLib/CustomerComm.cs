using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommLib
{
    public class CustomerComm
    {
        private IMailSender _mailSender;

        public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer(string toAddrs, string message)
        {
            // actual logic goes here
            //define messege and mail address
            //return _mailSender.SendMail("cust123@abc.com", "Some Message");
            return _mailSender.SendMail(toAddrs, message);
            //return true;
        }
    }
}