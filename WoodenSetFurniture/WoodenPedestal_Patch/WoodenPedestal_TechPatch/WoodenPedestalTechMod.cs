using System;
using HarmonyLib;

namespace Custom_Furniture.WoodenPedestal_Patch.WoodenPedestal_TechPatch
{
	// Token: 0x02000018 RID: 24
	[HarmonyPatch(typeof(Db), "Initialize")]
	internal class WoodenPedestalTechMod
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000374E File Offset: 0x0000194E
		private static void Postfix()
		{
			Db.Get().Techs.Get("Artistry").unlockedItemIDs.Add("WoodenPedestal");
		}
	}
}
