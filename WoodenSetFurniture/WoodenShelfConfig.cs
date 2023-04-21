using System;
using TUNING;
using UnityEngine;

namespace Custom_Furniture
{
	// Token: 0x0200000C RID: 12
	public class WoodenShelfConfig : IBuildingConfig
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00003127 File Offset: 0x00001327
		public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
		{
			EntityTemplateExtensions.AddOrGet<BuildingComplete>(go).isArtable = true;
			go.GetComponent<KPrefabID>().AddTag(GameTags.Decoration, false);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003148 File Offset: 0x00001348
		public override BuildingDef CreateBuildingDef()
		{
			float[] array = new float[] { 50f };
			string[] array2 = new string[] { "BuildableRaw" };
			EffectorValues none = NOISE_POLLUTION.NONE;
			BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef("ShelfWood", 3, 2, "shelf_w_prop_kanim", 30, 10f, array, array2, 1600f, 0, none, NOISE_POLLUTION.NONE, 0.2f);
			buildingDef.Floodable = false;
			buildingDef.SceneLayer = 16;
			buildingDef.Overheatable = false;
			buildingDef.AudioCategory = "Metal";
			buildingDef.BaseTimeUntilRepair = -1f;
			buildingDef.DefaultAnimState = "off";
			buildingDef.PermittedRotations = 3;
			return buildingDef;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000031EC File Offset: 0x000013EC
		public override void DoPostConfigureComplete(GameObject go)
		{
			Artable artable = go.AddComponent<Painting>();
			artable.stages.Add(new Artable.Stage("Default", INTERNALSTRINGS.SHELF_W.NO_SHELFW, "off", 0, false, 2));
			artable.stages.Add(new Artable.Stage("Good", INTERNALSTRINGS.SHELF_W.SHWMODEL_A, "art_a", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good2", INTERNALSTRINGS.SHELF_W.SHWMODEL_B, "art_b", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good3", INTERNALSTRINGS.SHELF_W.SHWMODEL_C, "art_c", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good4", INTERNALSTRINGS.SHELF_W.SHWMODEL_D, "art_d", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good5", INTERNALSTRINGS.SHELF_W.SHWMODEL_E, "art_e", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good6", INTERNALSTRINGS.SHELF_W.SHWMODEL_F, "art_f", 1, false, 2));
			SelectiveFurniture selectiveFurniture = EntityTemplateExtensions.AddOrGet<SelectiveFurniture>(go);
			selectiveFurniture.artable = artable;
		}

		// Token: 0x04000009 RID: 9
		public const string ID = "ShelfWood";
	}
}
