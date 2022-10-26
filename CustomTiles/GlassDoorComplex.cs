﻿namespace CustomTiles
{
    using STRINGS;
    using System;
    using System.Collections.Generic;
    using TUNING;
    using UnityEngine;

    class GlassDoorComplex : IBuildingConfig
    {
        public const string ID = "GlassDoorComplex";

        public override BuildingDef CreateBuildingDef()
        {
            float[] singleArray1 = new float[] { 100f, 50f };
            string[] textArray1 = new string[] { "RefinedMetal", "Transparent" };

            EffectorValues nONE = NOISE_POLLUTION.NONE;
            BuildingDef def = BuildingTemplates.CreateBuildingDef("GlassDoorComplex", 1, 2, "glass_door_complex_kanim", 30, 60f, singleArray1, textArray1, 1600f, BuildLocationRule.Tile, TUNING.BUILDINGS.DECOR.BONUS.TIER1, nONE, 1f);
            def.Overheatable = false;
            def.RequiresPowerInput = true;
            def.EnergyConsumptionWhenActive = 20f;
            def.Floodable = false;
            def.Entombable = false;
            def.IsFoundation = true;
            def.ViewMode = OverlayModes.Power.ID;
            def.TileLayer = ObjectLayer.FoundationTile;
            def.AudioCategory = "Metal";
            def.PermittedRotations = PermittedRotations.R90;
            def.ForegroundLayer = Grid.SceneLayer.InteriorWall;
            def.LogicInputPorts = DoorConfig.CreateSingleInputPortList(new CellOffset(0, 0));
            SoundEventVolumeCache.instance.AddVolume("door_external_kanim", "Open_DoorPressure", NOISE_POLLUTION.NOISY.TIER2);
            SoundEventVolumeCache.instance.AddVolume("door_external_kanim", "Close_DoorPressure", NOISE_POLLUTION.NOISY.TIER2);
            return def;
        }

        public static List<LogicPorts.Port> CreateSingleInputPortList(CellOffset offset)
        {
            List<LogicPorts.Port> list1 = new List<LogicPorts.Port>();
            list1.Add(LogicPorts.Port.InputPort(Door.OPEN_CLOSE_PORT_ID, offset, (string)STRINGS.BUILDINGS.PREFABS.DOOR.LOGIC_OPEN, (string)STRINGS.BUILDINGS.PREFABS.DOOR.LOGIC_OPEN_ACTIVE, (string)STRINGS.BUILDINGS.PREFABS.DOOR.LOGIC_OPEN_INACTIVE, false, false));
            return list1;
        }

        public override void DoPostConfigureComplete(GameObject go)
        {
            Door door = go.AddOrGet<Door>();
            door.hasComplexUserControls = true;
            door.unpoweredAnimSpeed = 0.65f;
            door.poweredAnimSpeed = 5f;
            door.doorClosingSoundEventName = "MechanizedAirlock_closing";
            door.doorOpeningSoundEventName = "MechanizedAirlock_opening";
            go.AddOrGet<ZoneTile>();
            go.AddOrGet<AccessControl>();
            go.AddOrGet<KBoxCollider2D>();
            Prioritizable.AddRef(go);
            go.AddOrGet<CopyBuildingSettings>().copyGroupTag = GameTags.Door;
            go.AddOrGet<Workable>().workTime = 5f;
            UnityEngine.Object.DestroyImmediate(go.GetComponent<BuildingEnabledButton>());
            go.GetComponent<AccessControl>().controlEnabled = true;
            go.GetComponent<KBatchedAnimController>().initialAnim = "closed";
        }
    }
}
