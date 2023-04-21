using System;
using HarmonyLib;

namespace Custom_Furniture.SingleChair_Patch.SingleChair_TechPatch
{
	// Token: 0x02000016 RID: 22
	[HarmonyPatch(typeof(Db), "Initialize")]
	internal class SingleChairTechMod
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00003696 File Offset: 0x00001896
		private static void Postfix()
		{
			Db.Get().Techs.Get("Luxury").unlockedItemIDs.Add("SingleChair");
		}
	}
}
