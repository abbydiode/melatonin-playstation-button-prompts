using HarmonyLib;

[HarmonyPatch(typeof(ControlHandler), "GetCtrlType")]
public class ControlHandler_GetCtrlType {
    public static int Postfix(int __result) => __result == 1  ? 2 : __result;
}