using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace InstantTransition
{
    [HarmonyPatch(typeof(GraphicsManager), nameof(GraphicsManager.SetLoading))]
    public static class Transition_GraphicsManager_Patch
    {

        public static void Postfix(GraphicsManager __instance, ref float __result)
        {
            __result = 0f;
        }
    }
}
