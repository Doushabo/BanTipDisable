using Il2Cpp;

namespace BanTipDisable.Patches;

[HarmonyPatch(typeof(PnlCheatRankTips), nameof(PnlCheatRankTips.CheckAndShow))]
internal static class Patch
{
    private static bool Prefix()
    {
        return false;
    }

    private static void Postfix()
    {
    }
}