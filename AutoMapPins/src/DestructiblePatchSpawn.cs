using HarmonyLib;

namespace AutoMapPins
{
    [HarmonyPatch(typeof(Destructible), "Start")]
    class DestructiblePatchSpawn
    {
        private static void Postfix(ref Destructible __instance)
        {
            var ht = __instance.GetComponent<HoverText>();
            if (ht)
            {
                string name;
                switch (ht.m_text)
                {
                    case "$piece_deposit_tin":
                        name = "Tin";
                        break;
                    case "$piece_deposit_copper":
                        name = "Copper";
                        break;
                    case "$piece_deposit_obsidian":
                        name = "Obsidian";
                        break;
                    case "$piece_deposit_silver":
                    case "$piece_deposit_silvervein":
                        name = "Silver";
                        break;
                    default:
                        return;
                }
                var po = __instance.gameObject.AddComponent<PinnedObject>();
                po.Init(name);
            }
        }
    }
}
