using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace all_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare this statement inside the method to Purpose
            //Allow Unicode characters to be displayed in console

            Console.OutputEncoding = System.Text.Encoding.UTF8;

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

        }
        
    }
}
