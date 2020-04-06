using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    public class InterfaceManager
    {
        public class ConsolePlayerInterface : IPlayerInterface
        {
            public void DisplayMessage(string message, params object[] parameters) =>
                Console.WriteLine(string.Format(message, parameters));

            public string GetInput() =>
                Console.ReadLine();

            public ConsolePlayerInterface(string message, params object[] parameters)
            {
                

            }

        }

        public interface IPlayerInterface
        {
            public void DisplayMessage(string message, params object[] parameters);
            public string GetInput();

        }


    }
}
