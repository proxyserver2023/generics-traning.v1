//==--==
// Why Generics are Used?
//==++==
/*==========================================
 * 
 * Purpose - necessity of generics
 *         - type safety of generics Example
 * 
 * 
 * Date    - September/02/2015
 * 
 * 
 * Demonstration - Generics improve the type safety
 *               - It improves the overhead of boxing and unboxing
 *               
 * 
 * ========================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Why_Generics
{
    class NonGen 
    {
        object ob; // ob is now of type object
        
        //Pass the constuctor a reference of type object

        public NonGen(object o) 
        {
            ob = o;
        } 

        // Return Type Object
        public object GetOb() 
        {
            return ob;
        }

        // Show Type of object
        public void ShowType() 
        {
            Console.WriteLine("Type of ob is " + ob.GetType());
        }
    } 

    // Demonstrate the Non-Generic Class

    class NonGenDemo
    {
        static void Main(string[] args)
        {
            NonGen iOb;

            // Create a NonGen Object.
            iOb = new NonGen(102);

            // Show the type of data stored in iOb
            iOb.ShowType();

            // Get The Value in iOb
            // This time a cast is necessary

            int v = (int)iOb.GetOb();
            Console.WriteLine("value: "+v);
            Console.WriteLine();

            // Create another nonGen object and store a string in it
            NonGen strOb = new NonGen("Hello NonGeneric Class, You are too boring! :P");
            
            // Show the type of data stored in a string objet  
            strOb.ShowType();

            // Get The value of strOb
            // Again, notice that a cast is necessary

            string str = (string)strOb.GetOb();
            Console.WriteLine("Value: "+str);
            
            // This Compiles but Conceptually Wrong!
            iOb = strOb;

            // The Following Line results a runtime Exception
            // v = (int) iOb.GetOb(); // runtime error
        }
    }
}
