using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player1 = new Character();
            Character player2 = new Character("Luke", "Skywalker", "Human");

            player1.FirstName = "Frodo";
            player1.LastName = "Baggins";
            player1.Race = "Hobbit";

            Console.WriteLine("Full name is {0}", player1.FullName());

            Console.WriteLine("Full name is {0}", player2.FullName());
        }
    }
}