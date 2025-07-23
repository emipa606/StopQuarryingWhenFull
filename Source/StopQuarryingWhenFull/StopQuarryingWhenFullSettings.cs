using Verse;

namespace StopQuarryingWhenFull;

/// <summary>
///     Definition of the settings for the mod
/// </summary>
internal class StopQuarryingWhenFullSettings : ModSettings
{
    public float FullPercentage = 0.75f;

    /// <summary>
    ///     Saving and loading the values
    /// </summary>
    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref FullPercentage, "fullPercentage", 0.75f);
    }
}