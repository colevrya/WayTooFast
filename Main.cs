using BepInEx;
using HarmonyLib;

namespace WayTooFastMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class WayTooFast_Plugin : BaseUnityPlugin
    {
        private const string modGUID = "com.colevr.WayTooFast";
        private const string modName = "WayTooFast";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private void Awake()
        {
            harmony.PatchAll();
            Logger.LogInfo("WayTooFast mod loaded successfully!");
        }
    }
}
