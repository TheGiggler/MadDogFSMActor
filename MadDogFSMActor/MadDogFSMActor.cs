using System;
using Akka.Actor;
using Akka.Event;
using models = MadDogFSM.MadDogFSMModels;
namespace MadDogFSM
{
    public class MadDogFSMActor:FSM<MadDogFSMModels.MadDogState,MadDogFSMModels.IMadDogMessageInterface>
    {
        public MadDogFSMActor()
        {
            StartWith(models.MadDogState.Ready, models.Uninitialized.Instance);

            When(models.MadDogState.Ready,message => 
            {
                if (message.FsmEvent is MadDogFSMModels.Start start && message.StateData is MadDogFSMModels.Uninitialized)
                {
                    try
                    {
                        return GoTo(models.MadDogState.Processing).Using(new models.Start(5));

                    }
                    catch (Exception ex)
                    {

                    }
                }
                return null;

            });

            When(models.MadDogState.Processing, message =>
            {
                if (message.FsmEvent is MadDogFSMModels.Start start && message.StateData is MadDogFSMModels.Uninitialized)
                {
                    try
                    {
                        return GoTo(models.MadDogState.Processing).Using(new models.Start(5));

                    }
                    catch (Exception ex)
                    {

                    }
                }
                return null;

            });

            When(models.MadDogState.Completed, message =>
            {
                if (message.FsmEvent is MadDogFSMModels.Start start && message.StateData is MadDogFSMModels.Uninitialized)
                {
                    try
                    {
                        return GoTo(models.MadDogState.Ready).Using(new models.Start(5));

                    }
                    catch (Exception ex)
                    {

                    }
                }
                return null;

            });

            OnTransition((initialState, nextState) =>
            {
               

            });





            Initialize();

            var stateName = this.StateName;
            var data = this.StateData;
        }

        public static Props Props => Props.Create(() => new MadDogFSMActor());
    }
}
