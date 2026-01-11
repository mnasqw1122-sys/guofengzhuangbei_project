using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using Duckov.Economy;
using ItemStatsSystem;

namespace guofengzhuangbei
{
    public static class DecomposeManager
    {
        public static void RegisterAll()
        {
            // 在这里添加所有分解配方
            
            // 装备ID：742083
            AddDecomposeRecipe(742083, new List<(int, int)> {
                (337, 2), (336, 2), (340, 4), (339, 5), 
                (362, 10), (743, 2), (764, 2), (1171, 2)
            });

            // 装备ID：742082
            AddDecomposeRecipe(742082, new List<(int, int)> {
                (362, 15), (743, 5), (1170, 3)
            });

            // 装备ID：742081
            AddDecomposeRecipe(742081, new List<(int, int)> {
                (362, 10), (743, 4), (1170, 2)
            });
            
            // 装备ID：742084
            AddDecomposeRecipe(742084, new List<(int, int)> {
                (362, 8), (743, 2)
            });

            // 装备ID：742085
            AddDecomposeRecipe(742085, new List<(int, int)> {
                (362, 5), (743, 2)
            });

            // 装备ID：742086
            AddDecomposeRecipe(742086, new List<(int, int)> {
                (362, 5), (743, 2), (444, 1)
            });

            // 装备ID：742087
            AddDecomposeRecipe(742087, new List<(int, int)> {
                (1170, 3), (743, 4), (1171, 2)
            });

            // 装备ID：742088
            AddDecomposeRecipe(742088, new List<(int, int)> {
                (1170, 3), (743, 4), (1171, 2)
            });

            // 装备ID：742089
            AddDecomposeRecipe(742089, new List<(int, int)> {
                (1170, 3), (743, 4), (1171, 2)
            });
 
            // 装备ID：742090
            AddDecomposeRecipe(742090, new List<(int, int)> {
                (362, 5),(1170, 2)
            });

            // 装备ID：742091
            AddDecomposeRecipe(742091, new List<(int, int)> {
                (1170, 5), (362, 6), (1171, 3), (743, 5)
            });
 
            // 装备ID：742093
            AddDecomposeRecipe(742093, new List<(int, int)> {
                (362, 4),(1170, 2)
            });
 
            // 装备ID：742094
            AddDecomposeRecipe(742094, new List<(int, int)> {
                (1171, 2),(1170, 4),(743, 5)
            });
 
            // 装备ID：742095
            AddDecomposeRecipe(742095, new List<(int, int)> {
                (362, 2),(1170, 1)
            });

            // 装备ID：742097
            AddDecomposeRecipe(742097, new List<(int, int)> {
                (362, 3),(743, 3),(1170, 2)
            });
 
            // 装备ID：742098
            AddDecomposeRecipe(742098, new List<(int, int)> {
                (362, 5),(743, 2)
            });

            // 装备ID：742102
            AddDecomposeRecipe(742102, new List<(int, int)> {
                (1170, 5), (743, 7), (1171, 3), (362, 5),
            });
 
            // 装备ID：742104
            AddDecomposeRecipe(742104, new List<(int, int)> {
                (362, 5),(1170, 3)
            });
            
            // 装备ID：742103
            AddDecomposeRecipe(742103, new List<(int, int)> {
                (362, 9), (743, 4)
            });
            
            // 装备ID：742105
            AddDecomposeRecipe(742105, new List<(int, int)> {
                (362, 5)
            });
            
            // 装备ID：742107
            AddDecomposeRecipe(742107, new List<(int, int)> {
                (362, 3)
            });

            // 装备ID：742108
            AddDecomposeRecipe(742108, new List<(int, int)> {
                (1170, 9), (743, 11), (1171, 5), (362, 8),
            });

            // 装备ID：742109
            AddDecomposeRecipe(742109, new List<(int, int)> {
                (1170, 12), (743, 15), (1171, 8), (362, 13),
            });

            // 装备ID：742110
            AddDecomposeRecipe(742110, new List<(int, int)> {
                (362, 5), (743, 2), (1170, 1)
            });            

            // 装备ID：742111
            AddDecomposeRecipe(742111, new List<(int, int)> {
                (362, 7), (743, 2), (1170, 2)
            });
 
            // 装备ID：742112
            AddDecomposeRecipe(742112, new List<(int, int)> {
                (1171, 2),(1170, 4),(743, 5)
            });
          }

        private static void AddDecomposeRecipe(int itemID, List<(int id, int count)> results, long money = 0)
        {
            var db = DecomposeDatabase.Instance;
            if (db == null)
            {
                Debug.LogError("[guofengzhuangbei] DecomposeDatabase Instance is null!");
                return;
            }

            FieldInfo entriesField = typeof(DecomposeDatabase).GetField("entries", BindingFlags.NonPublic | BindingFlags.Instance);
            if (entriesField == null)
            {
                Debug.LogError("[guofengzhuangbei] Cannot find field 'entries' in DecomposeDatabase.");
                return;
            }

            DecomposeFormula[] oldEntries = (DecomposeFormula[])entriesField.GetValue(db);
            List<DecomposeFormula> formulas = oldEntries != null ? oldEntries.ToList() : new List<DecomposeFormula>();

            // 如果已经存在该物品的配方，先移除旧的
            formulas.RemoveAll(f => f.item == itemID);

            // 构建新配方
            DecomposeFormula newFormula = new DecomposeFormula();
            newFormula.item = itemID;
            newFormula.valid = true;

            // 构建产出 Cost
            Cost resultCost = new Cost();
            resultCost.money = money;
            
            List<Duckov.Economy.Cost.ItemEntry> itemEntries = new List<Duckov.Economy.Cost.ItemEntry>();
            foreach(var res in results)
            {
                itemEntries.Add(new Duckov.Economy.Cost.ItemEntry { id = res.id, amount = res.count });
            }
            resultCost.items = itemEntries.ToArray();
            
            newFormula.result = resultCost;

            // 添加并保存
            formulas.Add(newFormula);
            db.SetData(formulas);
            db.RebuildDictionary();
            
            Debug.Log($"[guofengzhuangbei] 成功注册分解配方: 物品 {itemID} -> 产出 {results.Count} 种材料");
        }
    }
}