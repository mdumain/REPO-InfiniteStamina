using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteStamina.Patches
{
    [HarmonyPatch(typeof(PlayerController))]
    class PlayerStaminaPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPatch("FixedUpdate")]
        [HarmonyPostfix]

        static void InfiniteStaminaPatch(PlayerController __instance)
        {


            if (__instance.sprinting)
            {
                __instance.EnergyCurrent = __instance.EnergyStart;
            }
            else if (__instance.Sliding)
            {
                __instance.EnergyCurrent = __instance.EnergyStart;
            }
        }
    }
}
    