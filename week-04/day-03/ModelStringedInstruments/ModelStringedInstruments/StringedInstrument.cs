using System;
namespace Music
{

//Next, we add another abstract class, StringedInstrument which inherit from Instrument.It
//introduces numberOfStrings and
//Sound() method what's implementation is yet unknown
//but with the help of the Sound() the Play() method is fully implementable

    public abstract class StringedInstrument : Instrument
    {
        public int numberOfStrings;

        public virtual void Sound()
        {

        }

        public override void Play()
        {
            Sound();
        }


    }
}
