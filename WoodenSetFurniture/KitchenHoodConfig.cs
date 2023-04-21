using System;
using TUNING;
using UnityEngine;

namespace Custom_Furniture
{
	// Token: 0x02000005 RID: 5
	public class KitchenHoodConfig : IBuildingConfig
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000226A File Offset: 0x0000046A
		public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
		{
			EntityTemplateExtensions.AddOrGet<BuildingComplete>(go).isArtable = true;
			go.GetComponent<KPrefabID>().AddTag(GameTags.Decoration, false);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000228C File Offset: 0x0000048C
		public override BuildingDef CreateBuildingDef()
		{
			float[] array = new float[] { 50f };
			string[] array2 = new string[] { "RefinedMetal" };
			EffectorValues none = NOISE_POLLUTION.NONE;
			BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef("KitchenHood", 3, 2, "kitchen_hood_kanim", 30, 10f, array, array2, 1600f, 0, none, NOISE_POLLUTION.NONE, 0.2f);
			buildingDef.Floodable = false;
			buildingDef.SceneLayer = 16;
			buildingDef.Overheatable = false;
			buildingDef.AudioCategory = "Metal";
			buildingDef.BaseTimeUntilRepair = -1f;
			buildingDef.DefaultAnimState = "off";
			buildingDef.PermittedRotations = 3;
			return buildingDef;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002330 File Offset: 0x00000530
		public override void DoPostConfigureComplete(GameObject go)
		{
			Artable artable = go.AddComponent<Painting>();
			artable.stages.Add(new Artable.Stage("Default", INTERNALSTRINGS.KITCHEN_H.NO_KHOOD, "off", 0, false, 2));
			artable.stages.Add(new Artable.Stage("Good", INTERNALSTRINGS.KITCHEN_H.KHOOD_A, "art_a", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good2", INTERNALSTRINGS.KITCHEN_H.KHOOD_B, "art_b", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good3", INTERNALSTRINGS.KITCHEN_H.KHOOD_C, "art_c", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good4", INTERNALSTRINGS.KITCHEN_H.KHOOD_D, "art_d", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good5", INTERNALSTRINGS.KITCHEN_H.KHOOD_E, "art_e", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good6", INTERNALSTRINGS.KITCHEN_H.KHOOD_F, "art_f", 1, false, 2));
			SelectiveFurniture selectiveFurniture = EntityTemplateExtensions.AddOrGet<SelectiveFurniture>(go);
			selectiveFurniture.artable = artable;
		}

		// Token: 0x04000002 RID: 2
		public const string ID = "KitchenHood";
	}
}
