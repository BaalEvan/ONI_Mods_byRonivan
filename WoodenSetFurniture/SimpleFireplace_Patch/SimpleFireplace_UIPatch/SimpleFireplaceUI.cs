using System;
using HarmonyLib;

namespace Custom_Furniture.SimpleFireplace_Patch.SimpleFireplace_UIPatch
{
	// Token: 0x0200001B RID: 27
	[HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
	internal class SimpleFireplaceUI
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00003838 File Offset: 0x00001A38
		private static void Prefix()
		{
			string[] array = new string[] { "STRINGS.BUILDINGS.PREFABS.SIMPLEFIREPLACE.NAME", "Simple Fireplace" };
			Strings.Add(array);
			string[] array2 = new string[] { "STRINGS.BUILDINGS.PREFABS.SIMPLEFIREPLACE.DESC", "A house with no fireplace is a house without a heart." };
			Strings.Add(array2);
			string[] array3 = new string[] { "STRINGS.BUILDINGS.PREFABS.SIMPLEFIREPLACE.EFFECT", "A simple stone fireplace. Uses wood lumber to produce heat." };
			Strings.Add(array3);
			ModUtil.AddBuildingToPlanScreen("Utilities", "SimpleFireplace");
		}
	}
}
