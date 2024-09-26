using BepInEx;
using HarmonyLib;

namespace COM3D2.SubtitleEnabler.Plugin
{
    [BepInPlugin("com.inorys.subtitleenabler", "COM3D2.SubtitleEnabler.Plugin", "1.0.0.0")]
    public class SubtitleEnabler : BaseUnityPlugin
    {
        public void Awake()
        {
            Harmony.CreateAndPatchAll(typeof(SubtitleEnabler), null);
        }


        [HarmonyPatch(typeof(Product), "IsSupportLanguage")]
        [HarmonyPrefix]
        private static bool IsSupportLanguage(ref bool __result)
        {
            __result = true;
            return false;
        }

        [HarmonyPatch(typeof(Product), "supportMultiLanguage")]
        [HarmonyPostfix]
        private static void supportMultiLanguage(ref bool __result)
        {
            __result = true;
        }

        [HarmonyPatch(typeof(Product), "supportSubtitles")]
        [HarmonyPostfix]
        private static void supportSubtitles(ref bool __result)
        {
            __result = true;
        }
    }
}