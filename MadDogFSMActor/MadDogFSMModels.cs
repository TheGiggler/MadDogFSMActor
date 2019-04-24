using System;
using System.Collections.Generic;
using System.Text;

namespace MadDogFSM
{
    public class MadDogFSMModels
    {
        public enum MadDogState
        {
            Ready = 0,
            Processing = 1,
            Completed = 2

        }

        public interface IMadDogMessageInterface { }

        public class Start : IMadDogMessageInterface
        {
            public Start(int someInt)
            {
                SomeInt = someInt;
            }
            public int SomeInt { get; }
        }

        public class Abort : IMadDogMessageInterface
        {

        }

        public class Uninitialized : IMadDogMessageInterface
        {
            public static Uninitialized Instance = new Uninitialized();

            private Uninitialized() { }
        }


    }
}
