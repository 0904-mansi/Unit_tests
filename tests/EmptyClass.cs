using System;
namespace Demo.tests
{
	public class EmptyClass
	{
		public static void EmptyClasst()
		{
			try {
                int num = 2;

                EmptyClass1 obj = new EmptyClass1();

                string res = obj.EmptyClass(num);

                if (res == "skku")
                {
                    Console.WriteLine("Pass");
                }
                else
                {
                    Console.WriteLine("fail");
                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
	}
}

