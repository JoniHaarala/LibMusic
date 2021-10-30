using System;
using System.Collections.Generic;
using System.Text;

namespace LibMusic
{
    public class MainViewModel
    {
        public MainViewModel(){
            Onboardings = GetOnboarding();
        }

        public List<Onboarding> Onboardings { get; set; }

        private List<Onboarding> GetOnboarding()
        {
            return new List<Onboarding>
            {
                new Onboarding {Heading= "create events in minutes", Caption= "hola hola"},
                new Onboarding {Heading= "create events in minutes", Caption= "hola hola"},
                new Onboarding {Heading= "create events in minutes", Caption= "hola hola"}
            };
        }
    }

    public class Onboarding
    {
        public string Heading { get; set; }
        public string Caption { get; set; }
    }
}
