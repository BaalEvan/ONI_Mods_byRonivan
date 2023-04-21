using System;
using HarmonyLib;

namespace Custom_Furniture
{
	// Token: 0x02000003 RID: 3
	[HarmonyPatch(typeof(Artable), "OnSpawn")]
	public class Artable_OnSpawn_Patch
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000021B8 File Offset: 0x000003B8
		private static void Postfix(ref Artable __instance)
		{
			bool flag = __instance.gameObject.name == "TableWoodComplete" || __instance.gameObject.name == "ShelfWoodComplete" || __instance.gameObject.name == "KitchenHoodComplete" || __instance.gameObject.name == "SingleChairComplete";
			if (flag)
			{
				WorkChore<Artable> value = Traverse.Create(__instance).Field("chore").GetValue<WorkChore<Artable>>();
				bool flag2 = value != null;
				if (flag2)
				{
					value.Cancel("No need to change model.");
				}
			}
		}
	}
}
