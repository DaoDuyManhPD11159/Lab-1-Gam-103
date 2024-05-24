using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public static class Userdata
    {
        public static string ID;
        public static string UserName;
        public static float Health;
        public static int Point;


        static Userdata()
        {
            ID = "2024";
            UserName = "Hide om bush";
            Health = 100.5f; 
            Point = 100;
        }
       
    }
    
class Program
{
    static void Main()
    {
        Console.WriteLine("ID :" + Userdata.ID);
        Console.WriteLine("UserName: " + Userdata.UserName);
        Console.WriteLine("Health: " + Userdata.Health);
        Console.WriteLine("Point : " + Userdata.Point);

    }
}



