using StrategyPattern.AbstractProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunAbstractIteration();
        }
        static void RunAbstractIteration()
        {
            Client client = new Client();
            client.SetBehaviour(new ConcreteBehaviourA());
            client.Execute();
            Console.ReadLine();
        }
    }
}
