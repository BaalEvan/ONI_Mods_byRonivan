﻿using HarmonyLib;
using KMod;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace CustomTiles
{
    class ModInfo : KMod.UserMod2
    {
        public static string Namespace = "";

        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);

            Namespace = GetType().Namespace;
            Debug.Log($"{Namespace}: Loaded from: {this.mod.ContentPath}");
            Debug.Log($"{Namespace}: DLL version: {GetType().Assembly.GetName().Version} " +
                        $"supporting game build {this.mod.packagedModInfo.minimumSupportedBuild} ({this.mod.packagedModInfo.supportedContent})");
        }
    }
}