using NUnit.Framework;
using Moq;
using CustomerCommLib;
using NUnit.Framework.Legacy;

[TestFixture]
public class CustomerCommTests
{
    private Mock<IMailSender> _mailSenderMock;
    private CustomerComm _customerComm;

    [OneTimeSetUp]
    public void Init()
    {
        _mailSenderMock = new Mock<IMailSender>();
        _mailSenderMock.Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
        _customerComm = new CustomerComm(_mailSenderMock.Object);
    }

    [Test]
    public void SendMailToCustomer_ReturnsTrue()
    {
        var result = _customerComm.SendMailToCustomer();
        ClassicAssert.IsTrue(result);
    }
}
