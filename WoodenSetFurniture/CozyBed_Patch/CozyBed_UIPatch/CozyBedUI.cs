using System;
using HarmonyLib;

namespace Custom_Furniture.CozyBed_Patch.CozyBed_UIPatch
{
	// Token: 0x0200000F RID: 15
	[HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
	internal class CozyBedUI
	{
		// Token: 0x06000034 RID: 52 RVA: 0x000033E8 File Offset: 0x000015E8
		private static void Prefix()
		{
			string[] array = new string[] { "STRINGS.BUILDINGS.PREFABS.COZYBED.NAME", "Sofa Bed" };
			Strings.Add(array);
			string[] array2 = new string[] { "STRINGS.BUILDINGS.PREFABS.COZYBED.DESC", "Duplicants prefer wooden beds to cots and gain more stamina from sleeping in them." };
			Strings.Add(array2);
			string[] array3 = new string[] { "STRINGS.BUILDINGS.PREFABS.COZYBED.EFFECT", "A cozy bed that somewhat resembles a sofa. This bed grants extra stamina restoration." };
			Strings.Add(array3);
			ModUtil.AddBuildingToPlanScreen("Furniture", "CozyBed");
		}
	}
}
