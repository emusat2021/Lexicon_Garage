using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Lexicon_Garage.app.UserInterface;

namespace Lexicon_Garage.app
{
    public class UI : IUI
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public string GetInput()
        {
            return Console.ReadLine()!;
        }

        public void Clean()
        {
            Console.Clear();
        }

    }
}
