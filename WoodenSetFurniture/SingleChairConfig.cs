using System;
using TUNING;
using UnityEngine;

namespace Custom_Furniture
{
	// Token: 0x02000008 RID: 8
	public class SingleChairConfig : IBuildingConfig
	{
		// Token: 0x0600001B RID: 27 RVA: 0x0000295A File Offset: 0x00000B5A
		public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
		{
			EntityTemplateExtensions.AddOrGet<BuildingComplete>(go).isArtable = true;
			go.GetComponent<KPrefabID>().AddTag(GameTags.Decoration, false);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000297C File Offset: 0x00000B7C
		public override BuildingDef CreateBuildingDef()
		{
			float[] array = new float[] { 50f, 50f };
			string[] array2 = new string[]
			{
				"RefinedMetal",
				(-1142341158).ToString()
			};
			EffectorValues none = NOISE_POLLUTION.NONE;
			BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef("SingleChair", 2, 2, "single_chair_prop_kanim", 30, 10f, array, array2, 1600f, 1, none, NOISE_POLLUTION.NONE, 0.2f);
			buildingDef.Floodable = false;
			buildingDef.SceneLayer = 16;
			buildingDef.Overheatable = false;
			buildingDef.AudioCategory = "Metal";
			buildingDef.BaseTimeUntilRepair = -1f;
			buildingDef.DefaultAnimState = "off";
			buildingDef.PermittedRotations = 3;
			return buildingDef;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002A40 File Offset: 0x00000C40
		public override void DoPostConfigureComplete(GameObject go)
		{
			Artable artable = go.AddComponent<Painting>();
			artable.stages.Add(new Artable.Stage("Default", INTERNALSTRINGS.SIN_CHAIR.NO_CHAIR, "off", 0, false, 2));
			artable.stages.Add(new Artable.Stage("Good", INTERNALSTRINGS.SIN_CHAIR.CHAIR_A, "art_a", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good2", INTERNALSTRINGS.SIN_CHAIR.CHAIR_B, "art_b", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good3", INTERNALSTRINGS.SIN_CHAIR.CHAIR_C, "art_c", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good4", INTERNALSTRINGS.SIN_CHAIR.CHAIR_D, "art_d", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good5", INTERNALSTRINGS.SIN_CHAIR.CHAIR_E, "art_e", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good6", INTERNALSTRINGS.SIN_CHAIR.CHAIR_F, "art_f", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good7", INTERNALSTRINGS.SIN_CHAIR.CHAIR_G, "art_g", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good8", INTERNALSTRINGS.SIN_CHAIR.CHAIR_H, "art_h", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good9", INTERNALSTRINGS.SIN_CHAIR.CHAIR_I, "art_i", 1, false, 2));
			artable.stages.Add(new Artable.Stage("Good10", INTERNALSTRINGS.SIN_CHAIR.CHAIR_J, "art_j", 1, false, 2));
			SelectiveFurniture selectiveFurniture = EntityTemplateExtensions.AddOrGet<SelectiveFurniture>(go);
			selectiveFurniture.artable = artable;
		}

		// Token: 0x04000005 RID: 5
		public const string ID = "SingleChair";
	}
}
