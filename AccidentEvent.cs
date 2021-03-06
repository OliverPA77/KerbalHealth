﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KerbalHealth
{
    public class AccidentEvent : Event
    {
        public override string Name
        { get { return "Accident"; } }

        public override string Message()
        { return khs.Name + " has lost some health in an accident."; }

        public override bool Condition()
        { return true; }

        public override double ChancePerDay()
        {
            if (HighLogic.CurrentGame.Parameters.CustomParams<KerbalHealthEventsSettings>().AccidentPeriod > 0)
                return 1 / HighLogic.CurrentGame.Parameters.CustomParams<KerbalHealthEventsSettings>().AccidentPeriod;
            else return 0;
        }

        float MinDamage
        {
            get { return HighLogic.CurrentGame.Parameters.CustomParams<KerbalHealthEventsSettings>().AccidentMinDamage; }
            set { HighLogic.CurrentGame.Parameters.CustomParams<KerbalHealthEventsSettings>().AccidentMinDamage = value; }
        }

        float MaxDamage
        {
            get { return HighLogic.CurrentGame.Parameters.CustomParams<KerbalHealthEventsSettings>().AccidentMaxDamage; }
            set { HighLogic.CurrentGame.Parameters.CustomParams<KerbalHealthEventsSettings>().AccidentMaxDamage = value; }
        }

        double Damage(double x)
        { return 1 - MinDamage - (MaxDamage - MinDamage) * x; }

        protected override void Run()
        { khs.HP *= Damage(Core.rand.NextDouble()); }
    }
}
