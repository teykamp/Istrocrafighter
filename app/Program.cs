using System;

namespace app
{
    class Program
    {
        static void Main(string[] args){

            Console.Title = "Game Server";
            Server.Start(50, 2695);
            Console.ReadKey();
            
        }

    }
}