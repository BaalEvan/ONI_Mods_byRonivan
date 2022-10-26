﻿using System;
using TUNING;
using UnityEngine;

namespace CustomTiles
{
	public class AlertLightGreenConfig : IBuildingConfig
	{
        public const string ID = "AlertLightGreen";

        public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
		{
			go.GetComponent<KPrefabID>().AddTag(RoomConstraints.ConstraintTags.LightSource, false);
		}

		public override BuildingDef CreateBuildingDef()
		{
			EffectorValues none = NOISE_POLLUTION.NONE;
			BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef("AlertLightGreen", 1, 1, "alert_light_green_kanim", 10, 10f, BUILDINGS.CONSTRUCTION_MASS_KG.TIER0, MATERIALS.REFINED_METALS, 800f, BuildLocationRule.Anywhere, BUILDINGS.DECOR.BONUS.TIER1, none, 0.2f);
			buildingDef.RequiresPowerInput = true;
			buildingDef.Floodable = false;
			buildingDef.EnergyConsumptionWhenActive = 8f;
			buildingDef.Overheatable = false;
			buildingDef.ViewMode = OverlayModes.Light.ID;
			buildingDef.AudioCategory = "Metal";
			return buildingDef;
		}

		public override void DoPostConfigureComplete(GameObject go)
		{
			go.AddOrGet<EnergyConsumer>();
			go.AddOrGet<LoopingSounds>();
			Light2D light2D = go.AddOrGet<Light2D>();
			light2D.overlayColour = LIGHT2D.WALLLIGHT_OVERLAYCOLOR;
			light2D.Color = LIGHT2D.LIGHTBUG_COLOR_GREEN;
			light2D.Range = 1f;
			light2D.Angle = 0f;
			light2D.Direction = LIGHT2D.WALLLIGHT_DIRECTION;
			light2D.Offset = LIGHT2D.WALLLIGHT_OFFSET;
			light2D.shape = LightShape.Circle;
			light2D.drawOverlay = true;
			go.AddOrGetDef<LightController.Def>();
		}

		public override void DoPostConfigurePreview(BuildingDef def, GameObject go)
		{
			LightShapePreview lightShapePreview = go.AddComponent<LightShapePreview>();
			lightShapePreview.lux = 10;
			lightShapePreview.radius = 1f;
			lightShapePreview.shape = LightShape.Circle;
		}
	}
}
