using System;
using HarmonyLib;

namespace Custom_Furniture.KitchenHood_Patch.KitchenHood_UIPatch
{
	// Token: 0x02000019 RID: 25
	[HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
	internal class KitchenHoodUI
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00003780 File Offset: 0x00001980
		private static void Prefix()
		{
			string[] array = new string[] { "STRINGS.BUILDINGS.PREFABS.KITCHENHOOD.NAME", "Kitchen Hood" };
			Strings.Add(array);
			string[] array2 = new string[] { "STRINGS.BUILDINGS.PREFABS.KITCHENHOOD.DESC", "A kitchen hood decoration." };
			Strings.Add(array2);
			string[] array3 = new string[] { "STRINGS.BUILDINGS.PREFABS.KITCHENHOOD.EFFECT", "A kitchen hood made with polished metal. The model can be changed by using the Change Model option." };
			Strings.Add(array3);
			ModUtil.AddBuildingToPlanScreen("Furniture", "KitchenHood");
		}
	}
}
