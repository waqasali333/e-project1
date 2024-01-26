using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adnan_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string email = "aliaptech@gmail.com";
            //string found = "yes";
            //for(int i = 0; i < email.Length; i++) 
            //{
            //    if (email[i] == '@')
            //    {
            //        found = "yes";
            //        Console.WriteLine(i);
            //    }
            //    if (email[i] =='.')
            //    { 
            //        found = "yes"; 
            //    }
            //}
            //if (found == "yes") 
            //{
            //    Console.WriteLine("valid email");

            //}
            //else 

            //{
            //    Console.WriteLine("invalid email");
            //}
            //for (int i = 500; i < 600; i+= 10)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 1000; i > 500; i -= 100)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("enter any number");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("starting point");
            //Console.WriteLine("enter any number");
            //int end = int.Parse(Console.ReadLine());
            //Console.WriteLine("end point" end);

            //Console.WriteLine("ENTER STARTING POINT");
            //int STAT = int.Parse(Console.ReadLine());

            //Console.WriteLine("ENTER ENDING POINT");
            //int END = int.Parse(Console.ReadLine());

            //for (int i = STAT; i <= END; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int c = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = c; j <=4+ i; j++)
            //    {
            //        Console.Write(j);
            //        //Console.WriteLine("i="+i+"j="+j);
            //    }
            //    c = c + 1;
            //    Console.Write("\n");
            //}

            // placeholder
            //for (int i = 0,j=0;i<11;i++,j++)
            //{
            //    Console.WriteLine("the value of i={0} and " +
            //        "j={1}", i * i, j * j * j);
            //}

            //code snipet14
            //int investment;
            //int returns;
            //int expenses;
            //int profit;
            //int counter = 0;

            //for (investment = 1000, returns = 0; returns < investment;)
            //{
            //    Console.WriteLine("enter the monthlyexpenditure");
            //    expenses = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("enter the monthlyprofit");
            //    profit = Convert.ToInt32(Console.ReadLine());
            //    investment += expenses;
            //    returns += profit;
            //    counter++;
            //}
            //Console.WriteLine("number of months to break even:" + counter);

            //int i = 0;
            //int j = 0;
            //while (i < 5)
            //{
            //    while (j <= 4)

            //    {
            //        Console.Write(j);
            //        j++;
            //    }
            //    Console.Write("\n");
            //    i++;
            //    Console.ReadKey();
            //}

            //Q.1
            //int i = 0;
            //int j = 0;
            //while (i < 26) 
            //{
            //Console.WriteLine(i);
            //    i++;


            //}
            //Console.WriteLine("\n");
            //Console.ReadKey();

            // you are trying to display the output " 01 1 2 3 5 8 13" which of the following codes will help
            // you to achieve this?
            //a)
         int firstnum = 0;
         int secondnum = 1;
         int result;
        Console.Write("{0}", firstnum );
            Console.Write("{0}", secondnum);
            for(result = 0; result <10;)
            {
                result = firstnum + secondnum;
                Console.Write("{0}", result);
                firstnum = secondnum;
                secondnum = result;

            }
            Console.ReadKey();
        }
    }
            //for (int i = 0; i < 10; i += 1)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
       

        //Console.WriteLine("hello World");
        //Console.WriteLine("enter any number");
        //int number = int.Parse(Console.ReadLine()); 
        //int number = 10;
        //Console.WriteLine("the value of is" +number);

        //string name;
        //Console.WriteLine("enter the value name");
        //name = Console.ReadLine();

        //bool issofftoday;
        //Console.WriteLine("enter the bool value");
        //issofftoday = bool.Parse(Console.ReadLine());  
        //Console.WriteLine("the bool value is ");


        //char value;
        //Console.WriteLine("enter the value of char");
        //value= char.Parse(Console.ReadLine());
        //Console.WriteLine("the value is " + value); 

        //            char player1;
        //            char player2;
        //            Console.WriteLine("enter player 1 value");
        //            player1 = char.Parse(Console.ReadLine());
        //            Console.WriteLine(" enter player 2 value");
        //            player2 = char.Parse(Console.ReadLine());
        //            if(player1 =='P' || player1 == 'p' && player2== 'R' || player2 == 'r')
        //            {
        //                Console.WriteLine("player 2 wins Rock wins");
        //            }
        //            else if (player1 == 'R'  && player2 == 'P')
        //            {
        //                Console.WriteLine("player 1 wins Paper wins");
        //            }
        //                Console.ReadKey();

        //        }
        //    }
        //}
    }


        

