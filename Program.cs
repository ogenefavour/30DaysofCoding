using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }
    class MyBook : Book
    {
        protected int price;
        //B(string myString) : base(myString) { }
        //MyBook(string t, string a) : base(t, a) { }
        public MyBook(string title , string author, int price) : base(title,  author)
        {

            this.title = title;
            this.author = author;
            this.price = price;
        }


        public override void display()
        {
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"Author: {this.author}");
            Console.WriteLine($"Price: {this.price}");
        }
    }

    //class Solution
    //{

    //}
    class Program
    {

        //recursive function factorial!
        //static int factorial(int n)
        //{
        //    if (n == 0)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return n * factorial(n - 1);
        //    }
        //}
        static void Main(string[] args)
        {
           
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
            
            #region MyRegion
            //int[][] mat = new int[6][];

            //for (int i = 0; i < 6; i++)
            //{
            //    mat[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));


            //}
            //int max_sum = int.MinValue;
            //for (int i = 0; i < 6 - 2; i++)
            //{
            //    for (int j = 0; j < 6 - 2; j++)
            //    {
            //        // Considering mat[i][j] as top  
            //        // left cell of hour glass. 
            //        int sum = (mat[i][j] + mat[i][j + 1] +
            //                mat[i][j + 2]) + (mat[i + 1][j + 1]) +
            //                (mat[i + 2][j] + mat[i + 2][j + 1] +
            //                mat[i + 2][j + 2]);

            //        // If previous sum is less then  
            //        // current sum then update 
            //        // new sum in max_sum 
            //        max_sum = Math.Max(max_sum, sum);
            //    }
            //}
           
            //Console.WriteLine(max_sum);

        
        #endregion
        #region Decimal to binary

        //        ******** Convert from any base to another ********
        //String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
        //Console.Write("Decimal: ");
        //int decimalNumber = int.Parse(Console.ReadLine());

        //int remainder;
        //string result = string.Empty;
        //while (decimalNumber > 0)
        //{
        //    remainder = decimalNumber % 2;
        //    decimalNumber /= 2;
        //    result = remainder.ToString() + result;
        //}
        //Console.WriteLine("Binary:  {0}", result);

        //string[] val = result.Split('0');
        //int count = 0;

        //foreach (var item in val)
        //{
        //    count = item.Length > count ? item.Length : count;
        //}

        //Console.WriteLine(count);

        //Console.ReadLine();
        #endregion
        #region Recursive
        // Complete the factorial function below.

        //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        //TextWriter textWriter = new StreamWriter(Path.GetPathRoot(Environment.SystemDirectory) +"\\ Loop", true);

        //List<int> num = new List<int>();
        //int n = Convert.ToInt32(Console.ReadLine());

        //int result = factorial(n);
        //num.Add(result);



        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();

        #endregion
        #region Dictionary

        //Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        //int n = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    string[] inputPair = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToString(arrTemp));
        //    phoneBook.Add(inputPair[0], inputPair[1]);

        //}

        //bool check = true;

        //while(check)
        //{
        //    string name = Console.ReadLine();

        //    if (string.IsNullOrEmpty(name))
        //    {
        //        check = false;
        //    }
        //    else if (phoneBook.ContainsKey(name))
        //    {
        //        Console.WriteLine($"{name}={phoneBook[name]}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not found");
        //    }

        //}

        //Console.ReadLine();

        #endregion
        #region Array
        //int n = Convert.ToInt32(Console.ReadLine());

        //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        //;

        //for (int i = n; i > 0; i--)
        //{
        //    Console.Write($"{arr[i - 1]} ");
        //}
        #endregion

    }
    }
}
