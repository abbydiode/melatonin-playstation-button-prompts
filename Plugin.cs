using BepInEx;
using HarmonyLib;

namespace PlaystationPrompts {
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin {
        private void Awake() {
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} {PluginInfo.PLUGIN_VERSION} loaded!");
            new Harmony(PluginInfo.PLUGIN_GUID).PatchAll();
        }
    }
}
