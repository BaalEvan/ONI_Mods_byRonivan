using System;
using HarmonyLib;

namespace Custom_Furniture.TableWood_Patch.TableWood_UIPatch
{
	// Token: 0x02000011 RID: 17
	[HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
	internal class TableWoodUI
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000034A0 File Offset: 0x000016A0
		private static void Prefix()
		{
			string[] array = new string[] { "STRINGS.BUILDINGS.PREFABS.TABLEWOOD.NAME", "Wooden Table" };
			Strings.Add(array);
			string[] array2 = new string[] { "STRINGS.BUILDINGS.PREFABS.TABLEWOOD.DESC", "A simple wooden table prop." };
			Strings.Add(array2);
			string[] array3 = new string[] { "STRINGS.BUILDINGS.PREFABS.TABLEWOOD.EFFECT", "A fine table that provides decoration. The model can be changed by using the Change Model option." };
			Strings.Add(array3);
			ModUtil.AddBuildingToPlanScreen("Furniture", "TableWood");
		}
	}
}
