﻿namespace CustomTiles
{

    using STRINGS;
    using System;
    using System.Collections.Generic;
    using TUNING;
    using UnityEngine;

    public class FacilityDoorWhiteConfig : IBuildingConfig
    {
        public const string ID = "FacilityDoorWhite";

        public override BuildingDef CreateBuildingDef()
        {
            EffectorValues nONE = TUNING.NOISE_POLLUTION.NONE;
            BuildingDef def = BuildingTemplates.CreateBuildingDef("FacilityDoorWhite", 1, 2, "facility_door_white_kanim", 30, 10f, TUNING.BUILDINGS.CONSTRUCTION_MASS_KG.TIER1, MATERIALS.REFINED_METALS, 1600f, BuildLocationRule.Tile, TUNING.BUILDINGS.DECOR.BONUS.TIER1, nONE, 1f);
            def.Entombable = true;
            def.Floodable = false;
            def.IsFoundation = false;
            def.Overheatable = false;
            def.AudioCategory = "Metal";
            def.PermittedRotations = PermittedRotations.R90;
            def.ForegroundLayer = Grid.SceneLayer.InteriorWall;
            def.LogicInputPorts = CreateSingleInputPortList(new CellOffset(0, 0));
            SoundEventVolumeCache.instance.AddVolume("door_internal_kanim", "Open_DoorInternal", TUNING.NOISE_POLLUTION.NOISY.TIER2);
            SoundEventVolumeCache.instance.AddVolume("door_internal_kanim", "Close_DoorInternal", TUNING.NOISE_POLLUTION.NOISY.TIER2);
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
            door.unpoweredAnimSpeed = 1.4f;
            door.doorType = Door.DoorType.Internal;
            door.doorOpeningSoundEventName = "Open_DoorInternal";
            door.doorClosingSoundEventName = "Close_DoorInternal";
            go.AddOrGet<AccessControl>().controlEnabled = true;
            go.AddOrGet<CopyBuildingSettings>().copyGroupTag = GameTags.Door;
            go.AddOrGet<Workable>().workTime = 3f;
            go.GetComponent<KBatchedAnimController>().initialAnim = "closed";
            go.AddOrGet<ZoneTile>();
            go.AddOrGet<KBoxCollider2D>();
            Prioritizable.AddRef(go);
            UnityEngine.Object.DestroyImmediate(go.GetComponent<BuildingEnabledButton>());
        }
    }
}
