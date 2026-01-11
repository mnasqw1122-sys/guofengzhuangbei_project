using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using Duckov.Modding;
using Duckov.Economy;
using ItemStatsSystem;

namespace guofengzhuangbei
{
    public class ModBehaviour : Duckov.Modding.ModBehaviour
    {
        private AssetBundle bundle;
        private List<Item> loadedItems = new List<Item>();
        private string bundleName = "guofengzbmod"; 

        void Awake()
        {
            Debug.Log("[guofengzhuangbei] Mod Awake!");
            LoadContent();
        }

        void Start()
        {
            // 注册分解配方 (代码已移至 DecomposeManager.cs)
            DecomposeManager.RegisterAll();
            
            // 注册本地化文本 (代码已移至 LocalizationHelper.cs)
            LocalizationHelper.RegisterAll();

            // 注册商店物品
            MerchantManager.RegisterAll();
        }

        void Update()
        {
            
        }

        void LoadContent()
        {

            string assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string modPath = System.IO.Path.GetDirectoryName(assemblyLocation);
            string bundlePath = System.IO.Path.Combine(modPath, bundleName);

            if (System.IO.File.Exists(bundlePath))
            {
                Debug.Log($"[guofengzhuangbei] Loading bundle from: {bundlePath}");
                bundle = AssetBundle.LoadFromFile(bundlePath);
                if (bundle == null)
                {
                    Debug.LogError($"[guofengzhuangbei] Failed to load AssetBundle from {bundlePath}");
                    return;
                }

                var assets = bundle.LoadAllAssets<GameObject>();
                Debug.Log($"[guofengzhuangbei] Found {assets.Length} GameObjects in bundle.");
                
                foreach (var asset in assets)
                {
                    // 注册物品 (Item)
                    var item = asset.GetComponent<Item>();
                    if (item != null)
                    {
                        Debug.Log($"[guofengzhuangbei] Registering item: {item.name} (ID: {item.TypeID})");
                        ItemAssetsCollection.AddDynamicEntry(item);
                        loadedItems.Add(item);
                    }


                }
                

            }
            else
            {
                 Debug.LogError($"[guofengzhuangbei] AssetBundle not found at {bundlePath}. Please ensure 'guofengzbmod' is inside the mod folder.");
            }
        }

        void OnDestroy()
        {
            Debug.Log("[guofengzhuangbei] Unloading mod...");
            
            // 卸载物品
            foreach (var item in loadedItems)
            {
                ItemAssetsCollection.RemoveDynamicEntry(item);
            }
            loadedItems.Clear();
            

            
            if (bundle != null)
            {
                bundle.Unload(true);
            }
        }


    }
}