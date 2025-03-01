using HarmonyLib;

namespace WayTooFastMod
{
    
    [HarmonyPatch(typeof(PlayerController))]
    [HarmonyPatch("FixedUpdate")]
    public static class PlayerControllerSpeedPatch
    {
        
        private static bool hasSetOriginal = false;

        
        private static float origMoveSpeed = 0f;
        private static float origSprintSpeed = 0f;
        private static float origCrouchSpeed = 0f;

        
        private static readonly float speedMultiplier = 10f;

        
        static void Prefix(PlayerController __instance)
        {
            
            if (!hasSetOriginal)
            {
                origMoveSpeed = __instance.MoveSpeed;
                origSprintSpeed = __instance.SprintSpeed;
                origCrouchSpeed = __instance.CrouchSpeed;
                hasSetOriginal = true;
            }
        }

        
        static void Postfix(PlayerController __instance)
        {
            
            __instance.MoveSpeed = origMoveSpeed * speedMultiplier;
            __instance.SprintSpeed = origSprintSpeed * speedMultiplier;
            __instance.CrouchSpeed = origCrouchSpeed * speedMultiplier;
        }
    }
}
