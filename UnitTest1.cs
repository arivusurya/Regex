namespace valid;
using UserValidation;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        User user = new User();
        string[] validemails = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@abc.com.au","abc@gmail.com.com"};
        Boolean expected = true;
        foreach(string email in validemails){
        Boolean output = user.Validatemail(email);

        Assert.AreEqual(expected,output);
        }
    }
      public void TestMethod2()
    {
        User user = new User();
        string[] invalidemails = {"abc@.com.my","abc123@gmail.a","abc123@.com","abc@gmail.com.com"};
        Boolean expected = true;
        foreach(string email in invalidemails){
        Boolean output = user.Validatemail(email);

        Assert.AreEqual(expected,output);
        }
    }
}