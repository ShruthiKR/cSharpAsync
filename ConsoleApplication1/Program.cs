using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the data:");
            var dataread = Console.ReadLine();
            ArrayList datalist = new ArrayList();
            datalist.add(dataread);
           
            Console.WriteLine(datalist);

            

           
            /*
            ArrayList objarraylist = new ArrayList();
            
            Arrayexample arrayobj = new Arrayexample();
            arrayobj.arrayex();
             */
           
        }

     }
    public class Arrayexample
    {
        public void arrayex()
        {
            string[] str = new string[3];
            str[0] = "Raghav";
            str[1] = "shruthi";
            str[2] = "Aadhya";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
                Console.ReadLine();
               
            }
        }
    }
        
    
   
}
