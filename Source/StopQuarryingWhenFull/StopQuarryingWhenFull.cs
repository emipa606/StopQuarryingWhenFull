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

    public static float QuarryFullPercentage(Building_Quarry quarry)
    {
        float total = 0, filled = 0;

        foreach (var coord in quarry.OccupiedRect().ContractedBy(quarry.WallThickness).Cells)
        {
            total++;

            if (quarry.Map.thingGrid.CellContains(coord, ThingCategory.Item))
            {
                filled++;
            }
        }

        return filled / total;
    }

    public static bool QuarryIsFull(Building_Quarry quarry)
    {
        return QuarryFullPercentage(quarry) >= StopQuarryingWhenFullMod.instance.Settings.fullPercentage;
    }
}