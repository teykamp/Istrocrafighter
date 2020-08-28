using System;

namespace app
{
    class Program
    {
        static void Main(string[] args){

            Console.Title = "Game Server";
            // MaxPlayers, Port
            Server.Start(50, 2695);
            // key press to end program
            Console.ReadKey();
            
        }

    }
}