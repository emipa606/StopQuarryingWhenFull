using HarmonyLib;
using Quarry;
using Verse;
using Verse.AI;

namespace StopQuarryingWhenFull;

[HarmonyPatch(typeof(WorkGiver_MineQuarry), nameof(WorkGiver_MineQuarry.JobOnThing))]
internal static class WorkGiver_MineQuarry_JobOnThing_Patch
{
    public static bool Prefix(ref Job __result, Thing t)
    {
        if (t is not Building_Quarry quarry || !StopQuarryingWhenFull.QuarryIsFull(quarry))
        {
            return true;
        }

        __result = null;

        return false;
    }
}