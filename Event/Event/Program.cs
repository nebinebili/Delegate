using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Func(string str);

    class MyClass
    {
        public string text { get; set; }

        public MyClass(string text)
        {
            this.text = text;
        }
        public void Space(string str)
        {
            char[] cArray = str.ToCharArray();
            string space = String.Empty;
            for (int i = 0; i <str.Length; i++)
            {
                if (i == str.Length-1)
                {
                    space += cArray[i];
                    continue;
                }
                space += cArray[i] + "_";
            }
            Console.WriteLine($"Space(_)->{space}");
        }
        public void Reverse(string str)
        {

            char[] cArray = str.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            Console.WriteLine($"Reverse text->{reverse}");
        }
    }
    class Run
    {
        public void runFunc(Func func, string str)
        {
            func.Invoke(str);
        }
    }
    

    class Program
    {
        public static void Main()
        {
            Console.Write("Enter string:");

            var str = Console.ReadLine();
            MyClass cls = new MyClass(str);
            Func funcDell =cls.Reverse;
            funcDell += cls.Space;
 
            Run run = new Run();
            run.runFunc(funcDell, str);
        }


    }
}
