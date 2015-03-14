using System;

namespace NCPLAY.Website.Models
{
	public interface ITestClass
	{
		string WhoAmI();
	}
    public class TestClass : ITestClass
    {
	    public string WhoAmI()
	    {
		    return "I am dependency injection!!!";
	    }
    }
}