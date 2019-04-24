using System;
using MadDogFSM;
using Akka;
using Akka.Actor;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MadDogFSMActorTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.WaitAll(StartActor());
        }

        public static async Task StartActor()
        {
            ActorSystem system = ActorSystem.Create("maddog19");
            IActorRef actor = system.ActorOf<MadDogFSMActor>("maddog19Actor");
            //System.Threading.Thread.Sleep(10000);
            var obj = await actor.Ask(new MadDogFSMModels.Start(5));//, new TimeSpan(0, 0, 60));
            //System.Threading.Thread.Sleep(10000);

            Debug.Write(obj.GetType());
        }
    }
}
