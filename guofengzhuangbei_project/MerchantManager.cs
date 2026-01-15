using System;
using System.Collections.Generic;
using UnityEngine;
using Duckov.Economy;
using ItemStatsSystem;
using Duckov.Utilities;

namespace guofengzhuangbei
{
    public class MerchantManager
    {
        private static bool isInitialized = false;
        
        // 要添加的物品ID列表
        private static readonly int[] newItemIDs = new int[] 
        { 
            742081, 742082, 742084, 742085, 742086, 
            742087, 742088, 742090, 742092, 742093,
            742095, 742096, 742097, 742098, 742101,
            742103, 742104, 742105, 742106, 742107,
            742110, 742111, 742112, 742113,
        };

        public static void RegisterAll()
        {
            if (isInitialized) return;
            
            RegisterToMysteriousMerchant();
            
            isInitialized = true;
        }

        private static void RegisterToMysteriousMerchant()
        {
            try 
            {
                var database = StockShopDatabase.Instance;
                if (database == null)
                {
                    Debug.LogError("[guofengzhuangbei] StockShopDatabase.Instance is null!");
                    return;
                }

                // 查找神秘商人 (Myst)
                var mystProfile = database.GetMerchantProfile("Myst");
                if (mystProfile == null)
                {
                    Debug.LogWarning("[guofengzhuangbei] Could not find 'Myst' merchant profile. Trying 'Merchant_Myst'...");
                    mystProfile = database.GetMerchantProfile("Merchant_Myst");
                }

                if (mystProfile != null)
                {
                    Debug.Log($"[guofengzhuangbei] Found Mysterious Merchant profile: {mystProfile.merchantID}");
                    
                    foreach (int id in newItemIDs)
                    {
                        // 检查是否已经存在
                        if (mystProfile.entries.Exists(e => e.typeID == id))
                        {
                            continue;
                        }

                        var entry = new StockShopDatabase.ItemEntry
                        {
                            typeID = id,
                            maxStock = 1,
                            priceFactor = 1.3f,
                            possibility = 0.1f, // 10% 概率出现
                            forceUnlock = true,
                            lockInDemo = false
                        };
                        
                        mystProfile.entries.Add(entry);
                        Debug.Log($"[guofengzhuangbei] Added item {id} to Mysterious Merchant.");
                    }
                }
                else
                {
                    Debug.LogError("[guofengzhuangbei] Failed to find Mysterious Merchant profile.");
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"[guofengzhuangbei] Error registering to Mysterious Merchant: {ex.Message}");
            }
        }
    }
}
