using Verse;

namespace StopQuarryingWhenFull;

/// <summary>
///     Definition of the settings for the mod
/// </summary>
internal class StopQuarryingWhenFullSettings : ModSettings
{
    public float fullPercentage = 0.75f;

    /// <summary>
    ///     Saving and loading the values
    /// </summary>
    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref fullPercentage, "fullPercentage", 0.75f);
    }
}