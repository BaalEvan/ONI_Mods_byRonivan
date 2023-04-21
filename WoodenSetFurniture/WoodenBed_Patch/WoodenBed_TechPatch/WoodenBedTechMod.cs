using System;
using HarmonyLib;

namespace Custom_Furniture.WoodenBed_Patch.WoodenBed_TechPatch
{
	// Token: 0x0200000E RID: 14
	[HarmonyPatch(typeof(Db), "Initialize")]
	internal class WoodenBedTechMod
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000033B6 File Offset: 0x000015B6
		private static void Postfix()
		{
			Db.Get().Techs.Get("Artistry").unlockedItemIDs.Add("WoodenBed");
		}
	}
}
