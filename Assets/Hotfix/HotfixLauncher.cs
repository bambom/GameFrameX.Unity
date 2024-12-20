﻿using System.Net;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using GameFrameX;
using GameFrameX.Event.Runtime;
using GameFrameX.UI.FairyGUI.Runtime;
using GameFrameX.Network.Runtime;
using Hotfix.Proto;
using SimpleJSON;
using UnityEngine;
using GameFrameX.Runtime;
using GameFrameX.UI.Runtime;
using Hotfix.Config;
using Hotfix.Config.item;
using Hotfix.Config.test;
using Hotfix.Network;
using Hotfix.UI;

namespace Hotfix
{
    public static class HotfixLauncher
    {
        public static void Main()
        {
            Log.Info("Hello World HybridCLR");
            ProtoMessageIdHandler.Init(HotfixProtoHandler.CurrentAssembly);
            LoadConfig();
            LoadUI();
        }

        private static async void LoadUI()
        {
#if ENABLE_UI_FAIRYGUI
            GameApp.FUIPackage.AddPackageAsync(Utility.Asset.Path.GetUIPackagePath(FUIPackage.UICommonAvatar));
            await GameApp.UI.OpenUIFormAsync<UILogin>(Utility.Asset.Path.GetUIPath(FUIPackage.UILogin), UIGroupConstants.Floor.Name);
#elif ENABLE_UI_UGUI
            await GameApp.UI.OpenUIFormAsync<UILogin>(Utility.Asset.Path.GetUIPath(nameof(UILogin)), UIGroupConstants.Floor.Name);
#endif
        }

        static async void LoadConfig()
        {
            var tablesComponent = new TablesComponent();
            tablesComponent.Init(GameApp.Config);
            await tablesComponent.LoadAsync(ConfigLoader);
        }

        private static async Task<JSONNode> ConfigLoader(string file)
        {
            var assetHandle = await GameApp.Asset.LoadAssetAsync<TextAsset>(Utility.Asset.Path.GetConfigPath(file, Utility.Const.FileNameSuffix.Json));

            return JSON.Parse(assetHandle.GetAssetObject<TextAsset>().text);
        }
    }
}