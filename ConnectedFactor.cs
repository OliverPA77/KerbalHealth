﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace KerbalHealth
{
    public class ConnectedFactor : HealthFactor
    {
        public override string Name
        { get { return "Connected"; } }

        public override double BaseChangePerDay
        { get { return HighLogic.CurrentGame.Parameters.CustomParams<KerbalHealthFactorsSettings>().ConnectedFactor; } }

        public override double ChangePerDay(ProtoCrewMember pcm)
        {
            if (Core.IsInEditor) return IsEnabledInEditor() ? BaseChangePerDay : 0;
            return (Core.IsKerbalLoaded(pcm) && Core.KerbalVessel(pcm).Connection.IsConnectedHome) ? BaseChangePerDay : 0;
        }
    }
}
