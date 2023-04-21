using System;
using HarmonyLib;

namespace Custom_Furniture.SingleChair_Patch.SingleChair_UIPatch
{
	// Token: 0x02000015 RID: 21
	[HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
	internal class SingleChairUI
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00003610 File Offset: 0x00001810
		private static void Prefix()
		{
			string[] array = new string[] { "STRINGS.BUILDINGS.PREFABS.SINGLECHAIR.NAME", "Single Chair" };
			Strings.Add(array);
			string[] array2 = new string[] { "STRINGS.BUILDINGS.PREFABS.SINGLECHAIR.DESC", "A simple chair decoration." };
			Strings.Add(array2);
			string[] array3 = new string[] { "STRINGS.BUILDINGS.PREFABS.SINGLECHAIR.EFFECT", "A fine chair made from refined metals and plastic. The model can be changed by using the Change Model option." };
			Strings.Add(array3);
			ModUtil.AddBuildingToPlanScreen("Furniture", "SingleChair");
		}
	}
}
