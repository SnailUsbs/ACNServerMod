using BombRushMP.Plugin;
using HarmonyLib;

namespace ACNServerMod.Patches
{
    [HarmonyPatch(typeof(MPSettings), "ServerAddress", MethodType.Getter)]
    internal static class ServerAddressPatch
    {
        [HarmonyPostfix]
        static void Postfix(ref string __result)
        {
            __result = "00.000.000.000";
        }
    }
}