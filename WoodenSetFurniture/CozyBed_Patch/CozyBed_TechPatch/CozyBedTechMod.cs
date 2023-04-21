using System;
using HarmonyLib;

namespace Custom_Furniture.CozyBed_Patch.CozyBed_TechPatch
{
	// Token: 0x02000010 RID: 16
	[HarmonyPatch(typeof(Db), "Initialize")]
	internal class CozyBedTechMod
	{
		// Token: 0x06000036 RID: 54 RVA: 0x0000346E File Offset: 0x0000166E
		private static void Postfix()
		{
			Db.Get().Techs.Get("Luxury").unlockedItemIDs.Add("CozyBed");
		}
	}
}
