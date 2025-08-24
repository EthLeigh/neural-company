using UnityEngine;
using HarmonyLib;

namespace NeuralCompany.Patches;

[HarmonyPatch(typeof(Terminal))]
public static class CreditsStartPatch
{
    [HarmonyPostfix]
    [HarmonyPatch("Start")]
    public static void CheatCreditsPostfix(ref Terminal __instance)
    {
        __instance.groupCredits = 99999;
    }
}

[HarmonyPatch(typeof(StartOfRound))]
public static class CreditsStartRoundPatch
{
    [HarmonyPostfix]
    [HarmonyPatch("ResetShip")]
    public static void CheatCreditsPostfix()
    {
        Terminal terminal = Object.FindObjectOfType<Terminal>();
        terminal.groupCredits = 99999;
    }
}
