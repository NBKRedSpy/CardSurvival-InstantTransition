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

        public static void Prefix(GraphicsManager __instance, ref float __result, ref bool __runOriginal, bool _Loading, ref bool ___LoadingScreen)
        {
            ___LoadingScreen = _Loading;
            __instance.FadeToBlack.SetFade(FadeToBlackTypes.None, "", false);
            __result = 0f;
            __runOriginal = false;

        }
    }
}
