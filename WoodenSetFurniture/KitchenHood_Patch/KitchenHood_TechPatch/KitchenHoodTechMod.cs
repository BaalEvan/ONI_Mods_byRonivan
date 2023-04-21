using System;
using HarmonyLib;

namespace Custom_Furniture.KitchenHood_Patch.KitchenHood_TechPatch
{
	// Token: 0x0200001A RID: 26
	[HarmonyPatch(typeof(Db), "Initialize")]
	internal class KitchenHoodTechMod
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00003806 File Offset: 0x00001A06
		private static void Postfix()
		{
			Db.Get().Techs.Get("Artistry").unlockedItemIDs.Add("KitchenHood");
		}
	}
}
