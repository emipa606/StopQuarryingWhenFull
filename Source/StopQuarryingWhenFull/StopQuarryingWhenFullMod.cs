using Mlie;
using UnityEngine;
using Verse;

namespace StopQuarryingWhenFull;

[StaticConstructorOnStartup]
internal class StopQuarryingWhenFullMod : Mod
{
    /// <summary>
    ///     The instance of the settings to be read by the mod
    /// </summary>
    public static StopQuarryingWhenFullMod instance;

    private static string currentVersion;

    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="content"></param>
    public StopQuarryingWhenFullMod(ModContentPack content) : base(content)
    {
        instance = this;
        Settings = GetSettings<StopQuarryingWhenFullSettings>();
        currentVersion = VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
    }

    /// <summary>
    ///     The instance-settings for the mod
    /// </summary>
    internal StopQuarryingWhenFullSettings Settings { get; }

    /// <summary>
    ///     The title for the mod-settings
    /// </summary>
    /// <returns></returns>
    public override string SettingsCategory()
    {
        return "Stop Quarrying When Full";
    }

    /// <summary>
    ///     The settings-window
    ///     For more info: https://rimworldwiki.com/wiki/Modding_Tutorials/ModSettings
    /// </summary>
    /// <param name="rect"></param>
    public override void DoSettingsWindowContents(Rect rect)
    {
        var listing_Standard = new Listing_Standard();
        listing_Standard.Begin(rect);
        listing_Standard.Gap();
        listing_Standard.Label(
            "StopQuarryingWhenFull_Percentage_titlefull".Translate(Settings.fullPercentage.ToStringPercent()), -1,
            "StopQuarryingWhenFull_Percentage_desc".Translate());
        Settings.fullPercentage = Widgets.HorizontalSlider(listing_Standard.GetRect(20),
            Settings.fullPercentage, 0.01f, 1f, false, "StopQuarryingWhenFull_Percentage_title".Translate());
        if (currentVersion != null)
        {
            listing_Standard.Gap();
            GUI.contentColor = Color.gray;
            listing_Standard.Label("StopQuarryingWhenFull_CurrentModVersion_Label".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listing_Standard.End();
    }
}