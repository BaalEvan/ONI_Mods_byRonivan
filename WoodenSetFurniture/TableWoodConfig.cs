using System;
using TUNING;
using UnityEngine;

namespace Custom_Furniture
{
	// Token: 0x02000009 RID: 9
	public class TableWoodConfig : IBuildingConfig
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002C24 File Offset: 0x00000E24
		public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
		{
			EntityTemplateExtensions.AddOrGet<BuildingComplete>(go).isArtable = true;
			go.GetComponent<KPrefabID>().AddTag(GameTags.Decoration, false);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002C48 File Offset: 0x00000E48
		public override BuildingDef CreateBuildingDef()
		{
			float[] array = new float[] { 50f };
			string[] array2 = new string[] { "BuildableRaw" };
			EffectorValues none = NOISE_POLLUTION.NONE;
			BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef("TableWood", 3, 2, "table_w_prop_kanim", 30, 10f, array, array2, 1600f, 1, none, NOISE_POLLUTION.NONE, 0.2f);
			buildingDef.Floodable = false;
			buildingDef.SceneLayer = 16;
			buildingDef.Overheatable = false;
			buildingDef.AudioCategory = "Metal";
			buildingDef.BaseTimeUntilRepair = -1f;
			buildingDef.DefaultAnimState = "off";
			buildingDef.PermittedRotations = 3;
			return buildingDef;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002CEC File Offset: 0x00000EEC
		public override void DoPostConfigureComplete(GameObject go)
		{
			Artable artable = go.AddComponent<Painting>();
			artable.stages.Add(new Artable.Stage("Default", INTERNALSTRINGS.TABLE_W.NO_TABLEW, "off", 0, false, 2));
			artable.stages.Add(new Artable.Stage("Good", INTERNALSTRINGS.TABLE_W.TWMODEL_A, "art_a", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good2", INTERNALSTRINGS.TABLE_W.TWMODEL_B, "art_b", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good3", INTERNALSTRINGS.TABLE_W.TWMODEL_C, "art_c", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good4", INTERNALSTRINGS.TABLE_W.TWMODEL_D, "art_d", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good5", INTERNALSTRINGS.TABLE_W.TWMODEL_E, "art_e", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good6", INTERNALSTRINGS.TABLE_W.TWMODEL_F, "art_f", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good7", INTERNALSTRINGS.TABLE_W.TWMODEL_G, "art_g", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good8", INTERNALSTRINGS.TABLE_W.TWMODEL_H, "art_h", 1, false, 2));
			SelectiveFurniture selectiveFurniture = EntityTemplateExtensions.AddOrGet<SelectiveFurniture>(go);
			selectiveFurniture.artable = artable;
		}

		// Token: 0x04000006 RID: 6
		public const string ID = "TableWood";
	}
}
