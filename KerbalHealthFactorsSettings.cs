﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KerbalHealth
{
    class KerbalHealthFactorsSettings : GameParameters.CustomParameterNode
    {
        public override string Title { get { return "Health Factors"; } }
        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        public override bool HasPresets { get { return false; } }
        public override string Section { get { return "Kerbal Health"; } }
        public override string DisplaySection { get { return Section; } }
        public override int SectionOrder { get { return 2; } }

        [GameParameters.CustomFloatParameterUI("Assigned", toolTip = "HP change per day when the kerbal is assigned", minValue = -20, maxValue = 0, displayFormat = "F1", stepCount = 41)]
        public float AssignedFactor = -0.5f;

        [GameParameters.CustomFloatParameterUI("Crowded", toolTip = "HP change per day in a crowded vessel", minValue = -20, maxValue = 0, stepCount = 21)]
        public float CrowdedBaseFactor = -5;

        [GameParameters.CustomFloatParameterUI("Loneliness", toolTip = "HP change per day when the kerbal has no crewmates", minValue = -20, maxValue = 0, stepCount = 21)]
        public float LonelinessFactor = -1;

        [GameParameters.CustomFloatParameterUI("Microgravity", toolTip = "HP change per day when in orbital/suborbital flight or g-force < 0.1", minValue = -20, maxValue = 0, displayFormat = "F1", stepCount = 41)]
        public float MicrogravityFactor = -0.5f;

        [GameParameters.CustomFloatParameterUI("EVA", toolTip = "HP change per day when on EVA", minValue = -50, maxValue = 0, stepCount = 11)]
        public float EVAFactor = -30;

        [GameParameters.CustomFloatParameterUI("Sickness", toolTip = "HP change per day when a kerbal is sick", minValue = -20, maxValue = 0, stepCount = 21)]
        public float SicknessFactor = -5;

        [GameParameters.CustomFloatParameterUI("Connected", toolTip = "HP change per day when connected to Kerbin", minValue = 0, maxValue = 20, displayFormat = "F1", stepCount = 41)]
        public float ConnectedFactor = 0.5f;

        [GameParameters.CustomFloatParameterUI("Home", toolTip = "HP change per day when in Kerbin atmosphere", minValue = 0, maxValue = 20, stepCount = 21)]
        public float HomeFactor = 2;

        [GameParameters.CustomFloatParameterUI("At KSC", toolTip = "HP change per day when the kerbal is at KSC (available)", minValue = 0, maxValue = 20, stepCount = 21)]
        public float KSCFactor = 5;
    }
}
