using System;
using TUNING;
using UnityEngine;

namespace Custom_Furniture
{
	// Token: 0x02000002 RID: 2
	public class CozyBedConfig : IBuildingConfig
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
		{
			EntityTemplateExtensions.AddOrGet<LoopingSounds>(go);
			go.GetComponent<KPrefabID>().AddTag(RoomConstraints.ConstraintTags.Bed, false);
			go.GetComponent<KPrefabID>().AddTag(RoomConstraints.ConstraintTags.LuxuryBed, false);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002080 File Offset: 0x00000280
		public override BuildingDef CreateBuildingDef()
		{
			float[] array = new float[] { 120f, 200f, 40f };
			string[] array2 = new string[] { "RefinedMetal", "BuildingWood", "BuildingFiber" };
			EffectorValues none = NOISE_POLLUTION.NONE;
			BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef(CozyBedConfig.ID, 4, 2, "cozy_bed_kanim", 10, 10f, array, array2, 1600f, 1, BUILDINGS.DECOR.BONUS.TIER2, none, 0.3f);
			buildingDef.Overheatable = false;
			buildingDef.AudioCategory = "Metal";
			return buildingDef;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000210C File Offset: 0x0000030C
		public override void DoPostConfigureComplete(GameObject go)
		{
			go.GetComponent<KAnimControllerBase>().initialAnim = "off";
			Bed bed = EntityTemplateExtensions.AddOrGet<Bed>(go);
			bed.effects = new string[] { "LuxuryBedStamina", "BedHealth" };
			bed.workLayer = 21;
			Sleepable sleepable = EntityTemplateExtensions.AddOrGet<Sleepable>(go);
			sleepable.overrideAnims = new KAnimFile[] { Assets.GetAnim("anim_sleep_bed_kanim") };
			sleepable.workLayer = 21;
			EntityTemplateExtensions.AddOrGet<Ownable>(go).slotID = Db.Get().AssignableSlots.Bed.Id;
		}

		// Token: 0x04000001 RID: 1
		public static string ID = "CozyBed";
	}
}
