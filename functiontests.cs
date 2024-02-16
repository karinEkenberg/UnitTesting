using System;
namespace UnitTesting.Tests
{
    public static class Class1
    {
     
            public static void Function_ReturnsSnowballIfZero_ReturnString()
            {
                try
                {
                    //arrange - go get your variables, whatever you need, your classes, your functions
                    int num = 0;
                    Function function = new Function();

                    //act - execute this function
                    string result = function.ReturnsSnowballIfZero(num);
                    
                    //assert - whatever ever is returned is it what you want.
                    if (result == "Snowballed!")
                    {
                    Console.WriteLine("PASSED: Function.ReturnsSnowballIfZero_ReturnsString");
                    }
                    else
                {
                    Console.WriteLine("FAILED: Function.ReturnsSnowballIfZero_ReturnsString");
                }
                }
                catch (Exception ex) 
                {
                Console.WriteLine(ex);
                }
            }
        
    }
}



