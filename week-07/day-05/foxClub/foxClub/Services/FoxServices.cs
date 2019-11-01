using System;
using System.Collections.Generic;
using foxClub.Models;

namespace foxClub.Services
{
    public class FoxServices
    {

        public List<Fox> foxes;

        public FoxServices()
        {
            foxes = new List<Fox>();
        }

        public Fox FindFoxByName (string name)
        {
            return foxes.Find(f => f.Name == name);
        }

    }
}
