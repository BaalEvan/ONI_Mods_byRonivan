using System;
using HarmonyLib;

namespace Custom_Furniture.WoodenBed_Patch.WoodenBed_UIPatch
{
	// Token: 0x0200000D RID: 13
	[HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
	internal class WoodenBedUI
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00003330 File Offset: 0x00001530
		private static void Prefix()
		{
			string[] array = new string[] { "STRINGS.BUILDINGS.PREFABS.WOODENBED.NAME", "Wooden Bed" };
			Strings.Add(array);
			string[] array2 = new string[] { "STRINGS.BUILDINGS.PREFABS.WOODENBED.DESC", "Duplicants prefer wooden beds to cots and gain more stamina from sleeping in them." };
			Strings.Add(array2);
			string[] array3 = new string[] { "STRINGS.BUILDINGS.PREFABS.WOODENBED.EFFECT", "Provides a sleeping area for one Duplicant and restores additional Stamina." };
			Strings.Add(array3);
			ModUtil.AddBuildingToPlanScreen("Furniture", "WoodenBed");
		}
	}
}
