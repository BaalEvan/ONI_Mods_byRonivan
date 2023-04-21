using System;
using HarmonyLib;

namespace Custom_Furniture.WoodenPedestal_Patch.WoodenPedestal_UIPatch
{
	// Token: 0x02000017 RID: 23
	[HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
	internal class WoodenPedestalUI
	{
		// Token: 0x06000044 RID: 68 RVA: 0x000036C8 File Offset: 0x000018C8
		private static void Prefix()
		{
			string[] array = new string[] { "STRINGS.BUILDINGS.PREFABS.WOODENPEDESTAL.NAME", "Wooden Pedestal" };
			Strings.Add(array);
			string[] array2 = new string[] { "STRINGS.BUILDINGS.PREFABS.WOODENPEDESTAL.DESC", "The wooden pedestal provides a sophisticated way of thoughtful presentation." };
			Strings.Add(array2);
			string[] array3 = new string[] { "STRINGS.BUILDINGS.PREFABS.WOODENPEDESTAL.EFFECT", "Displays a single object, doubling its Decor value. Objects with negative decor will gain some positive decor when displayed." };
			Strings.Add(array3);
			ModUtil.AddBuildingToPlanScreen("Furniture", "WoodenPedestal");
		}
	}
}
