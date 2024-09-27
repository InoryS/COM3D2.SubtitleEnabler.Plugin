using BepInEx;
using HarmonyLib;

namespace COM3D2.SubtitleEnabler.Plugin
{
    [BepInPlugin("com.inorys.subtitleenabler", "COM3D2.SubtitleEnabler.Plugin", "1.0.0.1")]
    public class SubtitleEnabler : BaseUnityPlugin
    {
        public void Awake()
        {
            Harmony.CreateAndPatchAll(typeof(SubtitleEnabler));
        }

        [HarmonyPatch(typeof(Product), nameof(Product.supportMultiLanguage), MethodType.Getter)]
        [HarmonyPostfix]
        private static void supportMultiLanguage(ref bool __result)
        {
            __result = true;
        }


        [HarmonyPatch(typeof(Product), nameof(Product.supportSubtitles), MethodType.Getter)]
        [HarmonyPostfix]
        private static void supportSubtitles(ref bool __result)
        {
            __result = true;
        }


        [HarmonyPatch(typeof(Product), nameof(Product.IsSupportLanguage))]
        [HarmonyPrefix]
        private static bool IsSupportLanguage(ref bool __result)
        {
            __result = true;
            return false;
        }


        [HarmonyPatch(typeof(Product), nameof(Product.subTitleScenarioLanguage), MethodType.Getter)]
        [HarmonyPostfix]
        private static void subTitleScenarioLanguage(ref Product.Language __result)
        {
            __result = Product.systemLanguage;
        }
    }
}