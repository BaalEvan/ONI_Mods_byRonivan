using System;
using HarmonyLib;

namespace Custom_Furniture.ShelfWood_Patch.ShelfWood_TechPatch
{
	// Token: 0x02000014 RID: 20
	[HarmonyPatch(typeof(Db), "Initialize")]
	internal class ShelfWoodTechMod
	{
		// Token: 0x0600003E RID: 62 RVA: 0x000035DE File Offset: 0x000017DE
		private static void Postfix()
		{
			Db.Get().Techs.Get("InteriorDecor").unlockedItemIDs.Add("ShelfWood");
		}
	}
}
