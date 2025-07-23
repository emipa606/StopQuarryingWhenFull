using System.Reflection;
using HarmonyLib;
using Quarry;
using Verse;

namespace StopQuarryingWhenFull;

[StaticConstructorOnStartup]
public static class StopQuarryingWhenFull
{
    static StopQuarryingWhenFull()
    {
        new Harmony("me.lubar.StopQuarryingWhenFull").PatchAll(Assembly.GetExecutingAssembly());
    }

    private static float quarryFullPercentage(Building_Quarry quarry)
    {
        float total = 0, filled = 0;

        foreach (var intVec3 in quarry.OccupiedRect().ContractedBy(quarry.WallThickness).Cells)
        {
            total++;

            if (quarry.Map.thingGrid.CellContains(intVec3, ThingCategory.Item))
            {
                filled++;
            }
        }

        return filled / total;
    }

    public static bool QuarryIsFull(Building_Quarry quarry)
    {
        return quarryFullPercentage(quarry) >= StopQuarryingWhenFullMod.Instance.Settings.FullPercentage;
    }
}