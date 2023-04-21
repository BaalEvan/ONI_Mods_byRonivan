using System;
using HarmonyLib;

namespace Custom_Furniture.ShelfWood_Patch.ShelfWood_UIPatch
{
	// Token: 0x02000013 RID: 19
	[HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
	internal class ShelfWoodUI
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00003558 File Offset: 0x00001758
		private static void Prefix()
		{
			string[] array = new string[] { "STRINGS.BUILDINGS.PREFABS.SHELFWOOD.NAME", "Wooden Shelf" };
			Strings.Add(array);
			string[] array2 = new string[] { "STRINGS.BUILDINGS.PREFABS.SHELFWOOD.DESC", "A simple wooden shelf prop." };
			Strings.Add(array2);
			string[] array3 = new string[] { "STRINGS.BUILDINGS.PREFABS.SHELFWOOD.EFFECT", "A wooden wall shelf that provides decoration. The model can be changed by using the Change Model option." };
			Strings.Add(array3);
			ModUtil.AddBuildingToPlanScreen("Furniture", "ShelfWood");
		}
	}
}
