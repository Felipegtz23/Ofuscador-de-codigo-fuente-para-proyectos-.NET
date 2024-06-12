﻿
namespace Chiwiro.Protecciones.ChangeName.Analy
{

    public class EventDefAnalyzer : iAnalyze
    {
        public override bool Execute(object context)
        {
            dnlib.DotNet.EventDef ev = (dnlib.DotNet.EventDef)context;
            if (ev.IsRuntimeSpecialName)
                return false;
            return true;
        }
    }

}