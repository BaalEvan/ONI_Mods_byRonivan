using System;
using TUNING;
using UnityEngine;

namespace Custom_Furniture
{
	// Token: 0x0200000A RID: 10
	public class WoodenBedConfig : IBuildingConfig
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002E80 File Offset: 0x00001080
		public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
		{
			EntityTemplateExtensions.AddOrGet<LoopingSounds>(go);
			go.GetComponent<KPrefabID>().AddTag(RoomConstraints.ConstraintTags.Bed, false);
			go.GetComponent<KPrefabID>().AddTag(RoomConstraints.ConstraintTags.LuxuryBed, false);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002EB0 File Offset: 0x000010B0
		public override BuildingDef CreateBuildingDef()
		{
			float[] array = new float[] { 50f, 400f, 10f };
			string[] array2 = new string[] { "RefinedMetal", "BuildingWood", "BuildingFiber" };
			EffectorValues none = NOISE_POLLUTION.NONE;
			BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef(WoodenBedConfig.ID, 4, 2, "wooden_bed_kanim", 10, 10f, array, array2, 1600f, 1, BUILDINGS.DECOR.BONUS.TIER2, none, 0.3f);
			buildingDef.Overheatable = false;
			buildingDef.AudioCategory = "Metal";
			return buildingDef;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002F3C File Offset: 0x0000113C
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

		// Token: 0x04000007 RID: 7
		public static string ID = "WoodenBed";
	}
}
