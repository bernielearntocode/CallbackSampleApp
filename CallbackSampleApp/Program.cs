using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 c2 = new Class2();

            /*
            * Calling method on Class2 with callback method as parameter
            */
            c2.Method(CallBackMet);
        }

        /*
        * The callback method. This method prints the string sent in the callback
        */
        static void CallBackMet(string str)
        {
            Console.WriteLine("Callback was: " + str);
        }
    }

    public class Class2
    {
        /*
        * The method that calls back to the caller. Takes an action (method) as parameter
        */
        public void Method(Action<string> callback)
        {
            /*
            * Calls back to method CallBackMet in Class1 with the message specified
            */
            callback("The message to send back");
        }
    }
}
