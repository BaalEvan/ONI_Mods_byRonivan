using System;
using TUNING;
using UnityEngine;

namespace Custom_Furniture
{
	// Token: 0x02000007 RID: 7
	public class SimpleFireplaceConfig : IBuildingConfig
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002728 File Offset: 0x00000928
		public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
		{
			EntityTemplateExtensions.AddOrGet<LoopingSounds>(go);
			EntityTemplateExtensions.AddOrGet<MassiveHeatSink>(go);
			EntityTemplateExtensions.AddOrGet<MinimumOperatingTemperature>(go).minimumTemperature = 100f;
			PrimaryElement component = go.GetComponent<PrimaryElement>();
			component.SetElement(-279785280, true);
			component.Temperature = 294.15f;
			Storage storage = EntityTemplateExtensions.AddOrGet<Storage>(go);
			storage.capacityKg = 1000f;
			storage.SetDefaultStoredItemModifiers(Storage.StandardSealedStorage);
			storage.showInUI = true;
			ManualDeliveryKG manualDeliveryKG = EntityTemplateExtensions.AddOrGet<ManualDeliveryKG>(go);
			manualDeliveryKG.SetStorage(storage);
			manualDeliveryKG.requestedItemTag = WoodLogConfig.TAG;
			manualDeliveryKG.capacity = 300f;
			manualDeliveryKG.refillMass = 30f;
			manualDeliveryKG.choreTypeIDHash = Db.Get().ChoreTypes.MachineFetch.IdHash;
			ElementConverter elementConverter = EntityTemplateExtensions.AddOrGet<ElementConverter>(go);
			elementConverter.consumedElements = new ElementConverter.ConsumedElement[]
			{
				new ElementConverter.ConsumedElement(WoodLogConfig.TAG, 0.1f)
			};
			elementConverter.outputElements = new ElementConverter.OutputElement[]
			{
				new ElementConverter.OutputElement(0.015f, 1960575215, 312.5f, false, false, 0f, 0.5f, 1f, byte.MaxValue, 0)
			};
			ElementConsumer elementConsumer = EntityTemplateExtensions.AddOrGet<ElementConsumer>(go);
			elementConsumer.elementToConsume = -1528777920;
			elementConsumer.consumptionRate = 0.002f;
			elementConsumer.consumptionRadius = 3;
			elementConsumer.showInStatusPanel = true;
			elementConsumer.sampleCellOffset = new Vector3(0f, 1f, 0f);
			elementConsumer.isRequired = true;
			Prioritizable.AddRef(go);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000028A4 File Offset: 0x00000AA4
		public override BuildingDef CreateBuildingDef()
		{
			EffectorValues none = NOISE_POLLUTION.NONE;
			BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef("SimpleFireplace", 2, 3, "simple_fireplace_kanim", 30, 90f, BUILDINGS.CONSTRUCTION_MASS_KG.TIER5, MATERIALS.RAW_MINERALS, 1600f, 1, BUILDINGS.DECOR.BONUS.TIER0, none, 0.6f);
			buildingDef.ThermalConductivity = 9.4f;
			buildingDef.ExhaustKilowattsWhenActive = 18f;
			buildingDef.SelfHeatKilowattsWhenActive = 6f;
			buildingDef.LogicInputPorts = LogicOperationalController.CreateSingleInputPortList(new CellOffset(0, 0));
			buildingDef.ViewMode = OverlayModes.Power.ID;
			buildingDef.AudioCategory = "HollowMetal";
			return buildingDef;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000293A File Offset: 0x00000B3A
		public override void DoPostConfigureComplete(GameObject go)
		{
			EntityTemplateExtensions.AddOrGet<LogicOperationalController>(go);
			EntityTemplateExtensions.AddOrGetDef<PoweredActiveController.Def>(go);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000294B File Offset: 0x00000B4B
		public override void DoPostConfigurePreview(BuildingDef def, GameObject go)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000294E File Offset: 0x00000B4E
		public override void DoPostConfigureUnderConstruction(GameObject go)
		{
		}

		// Token: 0x04000004 RID: 4
		public const string ID = "SimpleFireplace";
	}
}
