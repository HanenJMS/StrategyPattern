using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.AbstractProject
{
    public class Client
    {
        IBehaviour behaviour;
        public void SetBehaviour(IBehaviour behaviour)
        {
            this.behaviour = behaviour;
        }
        public void Execute()
        {
            behaviour.RunBehaviour();
        }
    }
}