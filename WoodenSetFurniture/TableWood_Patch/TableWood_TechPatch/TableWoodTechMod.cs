using System;
using HarmonyLib;

namespace Custom_Furniture.TableWood_Patch.TableWood_TechPatch
{
	// Token: 0x02000012 RID: 18
	[HarmonyPatch(typeof(Db), "Initialize")]
	internal class TableWoodTechMod
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00003526 File Offset: 0x00001726
		private static void Postfix()
		{
			Db.Get().Techs.Get("InteriorDecor").unlockedItemIDs.Add("TableWood");
		}
	}
}
