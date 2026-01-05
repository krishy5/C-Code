using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Configuration;


namespace all_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare this statement inside the method to Purpose
            //Allow Unicode characters to be displayed in console

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            /*
                        // All Data Types
                        int id = 1;
                        string name = "krish";
                        char letter = 'y';
                        bool condition = true;
                        long lnum = 2407302L;
                        decimal nnum = 2.33M;
                        float num = 3.4454F;
                        double dnum = 230974.423;

                        // String Conversion
                        string val1 = "1";
                        Console.WriteLine(Convert.ToInt32(val1));

                        string val2 = "y";
                        Console.WriteLine(Convert.ToChar(val2));

                        string val3 = "true";
                        Console.WriteLine(Convert.ToBoolean(val3));

                        string val4 = "239659";
                        Console.WriteLine(Convert.ToInt64(val4));

                        string val5 = "3.44";
                        Console.WriteLine(Convert.ToDecimal(val5));

                        string val6 = "96235232.32532";
                        Console.WriteLine(Convert.ToDouble(val6));

                        string val7 = "4.547574";
                        Console.WriteLine(Convert.ToSingle(val7));

                        // Operators 
                        // +, -, *, /, %
                        int xv = 0;
                        Console.WriteLine(xv++); //here it will print 0 and then will change its val to 1
                        Console.WriteLine(++xv); //here the value which is converted to 1 will increment op=2

                        int xv1 = 5;
                        Console.WriteLine(xv1--);//5
                        Console.WriteLine(--xv1);//3

                        int xv2 = 0;
                        xv2++;
                        Console.WriteLine(xv2);//1

                        int xv3 = 0;
                        ++xv3;
                        Console.WriteLine(xv3);//1

                        // Operators with string

                        string op1 = "Krish ";
                        string op2 = "Tiwari";
                        Console.WriteLine(op1 + op2);

                        // Operators with char

                        char ch1 = 'k';
                        char ch2 = 't';
                        Console.WriteLine(ch1 + ch2);
                        Console.WriteLine(ch1 - ch2);
                        Console.WriteLine(ch1 / ch2);
                        Console.WriteLine(ch1 * ch2);// it will use unicode to operate 
                        // and output will be in unicode values

                        // var keyword

                        var vartxt = 122.33F;
                        // U can declare anything in var just dont use it much it decreases rediability of code

                        /* multi line comment
                        can be written like this*/
            /*
                        const string password = "krish9239438";
                        //password = "123"; // throw error const cant be changed

                        // Taking Input 

                        string sinp = Console.ReadLine(); // only for string
                        Console.WriteLine($"youve have written {sinp}");

                        int iinp = Convert.ToInt32(Console.ReadLine());// convert to take inp of other data types
                        Console.WriteLine($"youve entered integer {iinp}");

                        // C# Typecasting

                        int anynum = 23423;
                        string anynumtp = anynum.ToString();//no implicit or explicit for string

                        string s = "123";
                        int n = int.Parse(s);      // string → number


                        int tc1 = 2;
                        double tc2 = tc1;// declared with new data type is conv automatically (implicit)

                        int tc3 = 2;
                        double tc4 = (double)tc3;// explicit

                        // if state ment

                        int i = 5;
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("even");
                        }
                        else
                        {
                            Console.WriteLine("odd");
                        }

                        // Switch case

                        Console.WriteLine("choose 1 for true and 2 for false");
                        int swinp = Convert.ToInt32(Console.ReadLine());

                        switch (swinp)
                        {
                            case 1: Console.WriteLine(true);
                                break;
                            case 2: Console.WriteLine(false);
                                break;
                        }

                        // loops

                        for (int m = 1; m <= 3; m++)
                        {
                            Console.WriteLine(m);
                        }

                        Console.WriteLine();

                        int o = 1;
                        while (o <= 3)
                        {
                            Console.WriteLine(o++);

                        }

                        // Number formatting
                        double nf = (Double)10.0 / 3.0;
                        Console.WriteLine("{0:0.00}",nf);

                        //Currency
                        double c = (double)10.0 / 3.0;
                        Console.WriteLine(c.ToString("C",CultureInfo.CreateSpecificCulture("en-GB")));
                        //correct way

                        double newc = (double)67.0 / 5.0;
                        Console.WriteLine(c.ToString("C",CultureInfo.CreateSpecificCulture("en-IN")));

                        //Try Parse Function
                        string numinp = Console.ReadLine();
                        int defaultval = 0;
                        Console.WriteLine( int.TryParse(numinp,out defaultval));
                        //op true or flase
                        //input only string

                        // verbatium String
                        string vers = @"afdh ///af/a/f a/fs";
                        string vers1 = @"afdh \n \\af\a/f a/fs";
                        Console.WriteLine(@"sajhs""sas0k");

                        //Concateination
                        String concstri = string.Concat("a","b",vers1);

                        //more better concateination which increase readability of code
                        Console.WriteLine($"you declared{vers}");


                        // Empty string

                        // you cna use it instead of ""  

                        Console.WriteLine("Enter your name");
                        string namein = Console.ReadLine();

                        if (namein.Equals(string.Empty))// concern about values
                        {
                            Console.WriteLine($"your name is {namein}");
                        }
                        else
                        {
                            Console.WriteLine("name is empty");
                        }
            */

            // String is array of char[]

            //string message = "C# is interesting";
            //Console.WriteLine(message[0]); //C
            //Console.WriteLine(message.Length);
            //Console.WriteLine(message.Contains("C"));
            //for (int w = 0; w < message.Length; w++)
            //{

            //    Console.Write(message[w]);
            //    Thread.Sleep(100);

            //}
            //Console.WriteLine();

            ////-------------

            //bool tf = false;                 // create a boolean flag, initially false

            //for (int w = 0; w < message.Length; w++)  // loop through each character in the string
            //{
            //    // message[w] gives the character at index w

            //    if (message[w].Equals('C'))  // check if the current character is 'C'
            //    {
            //        tf = true;               // if 'C' is found, set flag to true
            //    }
            //}

            //// loop has finished checking all characters
            //// tf now tells whether 'C' was found or not

            //Console.WriteLine(tf);           // prints true if 'C' was found, otherwise false

            ////--------------------


            //// is null or is empty function
            //Console.WriteLine("Enter your name");
            //String nam = Console.ReadLine();


            //if (!string.IsNullOrEmpty(nam))
            //{
            //    Console.WriteLine(1);
            //}

            // Exercise take input print in reverse and in order
            //Console.WriteLine("Enter information");
            //string info = Console.ReadLine();

            //Console.WriteLine(" your orderd info is");

            //for(int i =0; i < info.Length; i++)
            //{
            //    Console.Write(info[i]);
            //}

            //Console.WriteLine(" your reversed info is");

            //for (int i= info.Length-1; i >= 0; i--)
            //{
            //    Console.Write(info[i]);
            //}

            //----------------------------------------

            // Arrays
            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 3;
            //arr[2] = 2;
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum = sum + arr[i];

            //}
            //Console.WriteLine(sum);

            //// search max num in array
            //int max = arr[0];
            //int maxposition = 0;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        maxposition = i;
            //    } 
            //}
            //Console.WriteLine($"max number is {max} at the position {maxposition}");

            // max no in array
            //int[] arrayy = new int[3];
            //arrayy[0] = 3;
            //arrayy[1] = 9;
            //arrayy[2] = 7;


            //int maxnum = arrayy[0];
            //int position = 0;
            //for (int i = 0; i < arrayy.Length; i++)
            //{
            //    if (arrayy[i] > maxnum)
            //    {
            //        maxnum = arrayy[i];
            //        position = i;
            //    }
            //}
            //Console.WriteLine($"max num in array is {maxnum} at position {position}");

            //// take input in array
            //Console.WriteLine("Enter size of array");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr1 = new int[n];
            //Console.WriteLine("Enter values in array");

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("The array youve entered is given as follows :");
            //Console.Write("[");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write($" {arr1[i]} ");
            //}
            //Console.Write("]");

            //Console.WriteLine();

            //// for each
            // used when you want to go from every case
            //foreach (int item in arr1)
            //{
            //    Console.Write($" {item} ");
            //}

            // check if its triangle

            //Console.WriteLine(" Enter 3 angle of triangle");
            //int[] angles = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    angles[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int sumAngle = angles[0] + angles[1] + angles[2];
            //Console.WriteLine(sumAngle == 180 ? "valid" : "Invalid");


            // array.sort funct

            //int[] arrSort = new int[]
            //{
            //    1,5,6,73,36,2,74,3
            //};
            //Array.Sort(arrSort);
            //foreach (var item in arrSort)
            //{
            //    Console.Write($" {item} "); // sorted array output

            //}
            //Console.WriteLine();

            //// array.Reverse function
            //Array.Reverse(arrSort);
            //foreach (var item in arrSort)
            //{
            //    Console.Write($" {item} "); // sorted array output

            //}

            //Console.WriteLine();

            //// type forr tab to get the reverse for loop
            //for (int i = arrSort.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($" {arrSort[i]} ");
            //}
            //Console.WriteLine();

            //// clear array
            //Array.Clear(arrSort, 0, arrSort.Length);
            //for (int i = 0; i < arrSort.Length; i++)
            //{
            //    Console.Write(arrSort[i]+" ");
            //}

            //int search = 5;

            //// INDEX OF
            //Console.WriteLine( Array.IndexOf(arrSort, search, 0, arrSort.Length)); 
            ////-1 == not found coz we cleared array its 0

            //------------------------------------------

            // LIST

            //List<string> ListNum = new List<string>();

            //bool condition = true;
            //while (condition == true) {
            //    Console.WriteLine(" press 1. add & 2. exit");
            //int x = Convert.ToInt32(Console.ReadLine());

            //    if (x == 1 || x == 2)
            //    {
            //        switch (x)
            //        {
            //            case 1:
            //                Console.WriteLine(" add notes");
            //                ListNum.Add(Console.ReadLine());
            //                condition = true;
            //                break;

            //            case 2:
            //                Console.WriteLine("exiting");
            //                condition = false;
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("wrong input");
            //        condition = true;
            //    }

            //}foreach (var item in ListNum)
            //    {
            //        Console.WriteLine(item);
            //    }

            ////------------------------------------------

            //// Dictioary

            //Dictionary<int, string> DictList = new Dictionary<int, string>
            //{
            //    { 1, "krish" },
            //    { 2, "Y"},
            //    { 3, "Tiwari" }

            //   };

            ////------------------------------------------

            // Exercise

            /* 
                  Create 2 lists with int data type, one for even num, one for odd
                  loop from 0-20
                    if no is even add to even list
                    if no is odd add to odd list
                print even list
                print odd list

             */

            //List<int> even = new List<int>();
            //List<int> odd = new List<int>();

            //for (int i = 0; i < 20; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        even.Add(i);
            //    }
            //    else
            //    {
            //        odd.Add(i);
            //    }
            //}
            //Console.WriteLine("even :");
            //foreach (var item in even )
            //{
            //    Console.Write(item+" ");
            //}
            //Console.WriteLine();
            
            //Console.WriteLine("odd :");
            //foreach (var item in odd)
            //{
            //    Console.Write(item+" ");
            //}

            //Console.WriteLine();

            ////

            //int f = 0;
            //int[] sarr = new int[5];
            //for (int i = 1; i <= sarr.Length; i++)
            //{
            //    sarr[f] = i * 7;
            //    f++;
            //}
            //foreach (var item2 in sarr)
            //{
            //    Console.Write(item2+" ");
            //}

            // Functions in C#

            // 1. Void functions

            void SwitchOnFan()
            {
                Console.WriteLine("Fan is On");
            }
            SwitchOnFan();

            // 2. Return Type Function

            int AAdd(int m , int n)
            {
                return m + n;
            }
            int sum = AAdd(3 , 4);
            Console.WriteLine(sum);

            // 3. Function Parameter

            void PrintName(string name)
            {
                Console.WriteLine("hello "+ name);
            }
            PrintName("c#");

            // 4. Optional Parameter

            void BuyCoffee(string type, int sugar = 1)
            {
                Console.WriteLine(type+" coffee with "+sugar+" sugar.");
            }
            BuyCoffee("cold");
            BuyCoffee("cold", 2);

            // named parameter

            void pnam(string nam, int rollNo)
            {
                Console.WriteLine(nam+" "+rollNo);
            }
            pnam(rollNo: 7,nam: " krish");// sequence doesnt matter

            // Reference parameter

            void AddBonus(ref int sal)
            {
                sal += 5000;
            }
            int sala = 50000;
            AddBonus(ref sala);
            Console.WriteLine(sala);

            //area of triangle

            double AreaOfTriangle(double b,double h)
            {
                return 0.5 * b * h;
            }
            double Aot = AreaOfTriangle(5 , 10);
            Console.WriteLine(Aot);

            // sum of int array
            int array(int[] a)
            {
                int summ =0;
                foreach (var item in a)
                {
                    summ += item;
                }
                return summ;
            }
            int[] baa = new int[]
            {
                1,2,3,4,5,6,7,8,9,10
            };
            array(baa);
           
        }
    }
}
