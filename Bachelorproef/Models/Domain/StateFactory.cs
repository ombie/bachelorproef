using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Bachelorproef.Models.Domain
{
    public static class StateFactory
    {
        private static Dictionary<string, VoorstelState> statesCache = FindAllDerivedStates();

        public static VoorstelState GetState(string stateTypeName)
        {
            return statesCache[stateTypeName];
        }

        private static Dictionary<string, VoorstelState> FindAllDerivedStates()
        {
            var derivedType = typeof(VoorstelState);
            var assembly = Assembly.GetAssembly(typeof(VoorstelState));
            return assembly.GetTypes().Where(t => t != derivedType && derivedType.IsAssignableFrom(t))
                        .Select(t => (VoorstelState)Activator.CreateInstance(t))
                        .ToDictionary(k => k.GetType().Name);
        }
    }
}