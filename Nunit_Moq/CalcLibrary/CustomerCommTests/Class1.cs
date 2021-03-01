using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerCommTests
{
    [TestFixture]
    public class Class1
    {
        private Mock<IMailSender> mockMailSender;
        private CustomerComm customerComm;

        [OneTimeSetUp]
        public void Init()
        {
            mockMailSender = new Mock<IMailSender>();
            customerComm = new CustomerComm(mockMailSender.Object);
        }

        [Test]
        [TestCase("a@gmail.com", "m1", true)]
        [TestCase("b@gmail.com", "m2", true)]
        [TestCase("c@gmail.com", "m3", true)]
        public void MailSenderTest(string addr, string messege, bool res)
        {
            //mockMailSender.Setup(m => m.SendMail("test@gmail.com", "random messege")).Returns(true);
            mockMailSender.Setup(m => m.SendMail(addr, messege)).Returns(res);
            bool actual = customerComm.SendMailToCustomer(addr, messege);
            Assert.AreEqual(res, actual);
        }
    }
}