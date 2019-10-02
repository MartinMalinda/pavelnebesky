using System;
namespace Music
{

//We start with a base, abstract class Instrument.
//it reserves(e.g. protected) the name of the instrument
//it should provide a Play() method.

    public abstract class Instrument
    {

        protected string name;

        public abstract void Play();
       
    }
}
