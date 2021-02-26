using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace AutoMapPins
{
    [BepInPlugin("net.bdew.valheim.automappins", "Auto Map Pins", "1.0.0")]
    class Mod : BaseUnityPlugin
    {
        public static ManualLogSource Log;

        void Awake()
        {
            var harmony = new Harmony("net.bdew.valheim.testmod");
            harmony.PatchAll();
            Log = Logger;
        }
    }
}
