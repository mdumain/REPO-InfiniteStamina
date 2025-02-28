using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using InfiniteStamina.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteStamina
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class InfiniteStamina : BaseUnityPlugin
    {
        private const string modGUID = "Galaxcito.REPO.InfiniteStamina";
        private const string modName = "Infinite Stamina";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        internal ManualLogSource mls;

        internal static InfiniteStamina instance { get; private set; }


        void Awake()
        {
            if(instance == null)
            {
                instance = this;
            }

            mls = Logger;

            mls.LogInfo("The mod Infinite Stamina by Galaxcito was loaded successfully :p");

            harmony.PatchAll(typeof(InfiniteStamina));
            harmony.PatchAll(typeof(PlayerStaminaPatch));
        }

    }
}
