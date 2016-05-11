using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ITCAllApps
{
    delegate void TestDelegateNew(string s);
    delegate string TestStringDelegate(int i);

    public delegate parent CovarianceHandler();

    //For lambda expression
    delegate int delLamda(int i);
    delegate double CallArepointer(int r);

    public delegate parent ContravarianceHandler(Child c);

    public class Program
        
    {
        //Lamnda expression
        static CallArepointer cpointer = calculateArea;

        public static parent pCovariance()
        {
            return new parent();
        }
        public static Child cCovariance()
        {
            return new Child();
        }

        public static parent PContravariance(parent p)
        {
            return p;
        }
        public static parent CContravariance(Child c)
        {
            return c as parent;
        }


        static void M(string s)
        {
            Debug.WriteLine(s);
        }
        //Func C#
    

        static int sum(int t1,int t2)
        {
            return t1 + t2;
        }

        //Lambda expression
        static double calculateArea(int r)
        {
            return 3.14 * r * r;
        }

        static void Main(string[] args)
        {

            List<int> oyears = new List<int>();
            oyears.Add(2000);
            oyears.Add(2001);
            oyears.Add(2002);
            oyears.Add(2003);





            //Lambda expression
            double area = cpointer.Invoke(5);
            Console.WriteLine(area);

            CallArepointer cvpointer = t => 3.14 * t * t;
            double newera = cpointer(4);
            Console.WriteLine(newera);


            //Lambda+Func (Ths is more swwter)


            Func<double, double> arealamda = y => 3.14 * y * y;

            double nnewares = arealamda(20);

            //Predicate
            Predicate<string> testPredicate = x => x.Length > 5;
            bool test = testPredicate("Manoj");

            //Covariance in Delegate
            //CovarianceHandler handler = new CovarianceHandler(pCovariance);

            CovarianceHandler handler = pCovariance;
            Console.WriteLine(handler().GetType().ToString());

            //CovarianceHandler handler1 = new CovarianceHandler(cCovariance);
            CovarianceHandler handlerNew = cCovariance;
            Console.WriteLine(handler().GetType().ToString());



            ContravarianceHandler handlerTest = PContravariance;
            Console.WriteLine(handlerTest(new Child()).GetType().ToString());

            ContravarianceHandler handler1 = CContravariance;
            Console.WriteLine(handler1(new Child()).GetType().ToString());




            string myName = "Manoj Chinthaka Weerasorriya";
            myName = "Manoj Kumaru Weerasooriya";

            Console.WriteLine("Enter your Name");
            myName = Console.ReadLine();


            Debug.WriteLine(myName);



            //create delegate instances using anonymous method
            NumberChanger nc = delegate (int x)
              {
                  Debug.WriteLine("Anonymus Method :{0}", x);
              };

            //calling the delegate using the anonymous method 
            nc(10);

            //instantiating the delegate using the named methods 
            nc = new NumberChanger(TestDelegate.AddNum);

            //calling the delegate using the named methods 
            nc(5);

            //instantiating the delegate using another named methods 
            nc = new NumberChanger(TestDelegate.MultNum);

            //calling the delegate using the named methods 
            nc(2);


            ///
            /// The Evolution of Delegates in C#
            /// 
            // Original delegate syntax required 
            // initialization with a named method.
            TestDelegateNew testDelA = new TestDelegateNew(M);

            // C# 2.0: A delegate can be initialized with
            // inline code, called an "anonymous method." This
            // method takes a string as an input parameter.
            TestDelegateNew testDelB = delegate (string s) { Debug.WriteLine(s); };
            TestDelegateNew testDelegatePro = delegate (string d)
              {
                  Debug.WriteLine(d);
              };
            TestStringDelegate testString = delegate (int x)
              {
                  return "Manoj Weerasooriya"+x;
                  //return 4;
              };
            testString(10);



            // C# 3.0. A delegate can be initialized with
            // a lambda expression. The lambda also takes a string
            // as an input parameter (x). The type of x is inferred by the compiler.
            TestDelegateNew testDelC = (x) => { Debug.WriteLine(x); };

            TestDelegateNew tsetDelPc = c => Debug.WriteLine(c);

            TestStringDelegate myStringdel = c => { return "Manoj Weerasoriya"; };


            //Invoke the delegates.
            testDelA("Hello. My name is Manoj");
            testDelB("That's nothing. I'm anonymous and ");
            testDelC("I'm a famous author.");
            tsetDelPc("I'm Manoj Weerasorriya");

            //Keep console window open in debug mode.
            //Debug.WriteLine("Press any key to exit.");
            //Debug.ReadKey();

            //Console.ReadKey();

            //Covariance with delegate

            //String a = "sasas";
            //a.ToString();


            //A tsetA = new A();
            //A testB = tsetA;



            //Func in C#
            Func<int, int, int> someOperation = sum;

            int result=someOperation(10, 10);

            Console.WriteLine(result);

            
            Func<int> getRandomNumber = delegate ()
              {
                  Random r = new Random();
                  return r.Next(1, 100);
              };

            //Lambnda expression
            delLamda myLmada = (x) => x * x;
            int j = myLmada(10);


            Func<int, int, int> delSome = (x, y) => x + y;
            int valSome= delSome(5, 10);


            //Non static class
            nonStaticClass.run();


            //Const vs Readonly
            readOnlyvsConst testConst = new readOnlyvsConst();
            testConst.getConatValue();
            testConst.getReadonlyValue();
           

            readOnlyvsConst.getAll();

          


        }
    }
}
