using System;
namespace Demo.tests
{
	public class EmptyClass
	{
		public static void EmptyClasst()
		{
		try {
			//Arrange
			int num = 2;

			EmptyClass1 obj = new EmptyClass1();
			//Act
			string res = obj.EmptyClass(num);
			
			//Assert
			if (res == "skku")
			{
			    Console.WriteLine("Pass");
			}
			else
			{
			    Console.WriteLine("fail");
			}
                  }

		 //exception
		    catch (Exception e)
		    {
			Console.WriteLine(e);
		    }
      	      }
	}
}

