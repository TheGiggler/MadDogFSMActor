using Akka.Actor;
using Akka.TestKit.Xunit2;
using FluentAssertions;
using System.Collections.Immutable;
using Xunit;

namespace MadDogFSM
{
    public class MadDogFSMTests:TestKit
    {
        [Fact]
        public void InitializationTest()
        {
            var madDogActor = Sys.ActorOf(Props.Create <MadDogFSMActor>());
            Assert.NotNull(madDogActor);
        }
    }
}
