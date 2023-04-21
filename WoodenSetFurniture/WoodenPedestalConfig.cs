using System;
using System.Collections.Generic;
using TUNING;
using UnityEngine;

namespace Custom_Furniture
{
	// Token: 0x0200000B RID: 11
	public class WoodenPedestalConfig : IBuildingConfig
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002FE8 File Offset: 0x000011E8
		public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
		{
			Storage.StoredItemModifier[] array = new Storage.StoredItemModifier[] { 2, 3 };
			EntityTemplateExtensions.AddOrGet<Storage>(go).SetDefaultStoredItemModifiers(new List<Storage.StoredItemModifier>(array));
			Prioritizable.AddRef(go);
			SingleEntityReceptacle singleEntityReceptacle = EntityTemplateExtensions.AddOrGet<SingleEntityReceptacle>(go);
			singleEntityReceptacle.AddDepositTag(GameTags.PedestalDisplayable);
			singleEntityReceptacle.occupyingObjectRelativePosition = new Vector3(0f, 1.2f, -1f);
			EntityTemplateExtensions.AddOrGet<DecorProvider>(go);
			EntityTemplateExtensions.AddOrGet<ItemPedestal>(go);
			go.GetComponent<KPrefabID>().AddTag(GameTags.Decoration, false);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000306C File Offset: 0x0000126C
		public override BuildingDef CreateBuildingDef()
		{
			float[] array = new float[] { 20f, 250f };
			string[] array2 = new string[] { "RefinedMetal", "BuildingWood" };
			EffectorValues none = NOISE_POLLUTION.NONE;
			BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef("WoodenPedestal", 1, 2, "wooden_pedestal_kanim", 10, 30f, array, array2, 800f, 1, BUILDINGS.DECOR.BONUS.TIER1, none, 0.2f);
			buildingDef.DefaultAnimState = "pedestal";
			buildingDef.Floodable = false;
			buildingDef.Overheatable = false;
			buildingDef.ViewMode = OverlayModes.Decor.ID;
			buildingDef.AudioCategory = "Glass";
			buildingDef.AudioSize = "small";
			return buildingDef;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000311B File Offset: 0x0000131B
		public override void DoPostConfigureComplete(GameObject go)
		{
		}

		// Token: 0x04000008 RID: 8
		public const string ID = "WoodenPedestal";
	}
}
