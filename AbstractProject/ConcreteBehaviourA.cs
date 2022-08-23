using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.AbstractProject
{
    internal class ConcreteBehaviourA : IBehaviour
    {
        public void RunBehaviour()
        {
            Console.WriteLine($"Running {this.GetType().ToString()}");
        }
    }
}
