using System.Reflection;
using UnityEngine;

namespace guofengzhuangbei
{
    public static class LocalizationHelper
    {
        public static void RegisterAll()
        {
            // 在这里添加所有本地化文本
            
            // --- 装备 1: guofengjia1 ---
            RegisterText("guofengjia1", "国风·明护甲五");
            RegisterText("guofengjia1_Desc", "国风装备系列：根据明代风格制作的护甲，并没有进行现代化改造，但还是提供了不错的防护性能。");

            // --- 装备 2: guofengjia2 ---
            RegisterText("guofengjia2", "国风·明护甲六");
            RegisterText("guofengjia2_Desc", "国风装备系列：根据明代风格制作的护甲，明代的基础版型，就给我们提供了不错的防护，根据时代变化做了一些改动。");

            // --- 装备 3: guofengjia3 ---
            RegisterText("guofengjia3", "国风·明改造护甲六");
            RegisterText("guofengjia3_Desc", "国风装备系列：根据明代风格制作的护甲，进行了不多的时代化改造，对于本来的形体和美学并没有做太多改动。");
            
            // --- 装备 4: guofengjia4 ---
            RegisterText("guofengjia4", "国风·明护甲四");
            RegisterText("guofengjia4_Desc", "国风装备系列：根据明代风格制作的护甲，提供了基本的防护性能，兼顾了机动性和便捷性。");
            
            // --- 装备 5: guofengjia5 ---
            RegisterText("guofengjia5", "国风·明护甲三");
            RegisterText("guofengjia5_Desc", "国风装备系列：根据明代风格制作的护甲，提供了基本的防护性能，正面有个勇字，战斗中突出一个勇敢。");

            // --- 装备 6: guofengjia6 ---
            RegisterText("guofengjia6", "国风·祥云护甲");
            RegisterText("guofengjia6_Desc", "国风装备系列：这件护甲，就像在天空中飞行的云一样。");

            // --- 装备 7: guofengjia7 ---
            RegisterText("guofengjia7", "国风·重型纹饰护甲");
            RegisterText("guofengjia7_Desc", "国风装备系列：根据鸭星五级重形护甲改造。");

            // --- 装备 8: guofengjia8 ---
            RegisterText("guofengjia8", "国风·作战纹饰护甲");
            RegisterText("guofengjia8_Desc", "国风装备系列：根据鸭星五级作战护甲改造。");

            // --- 装备 9: guofengjia9 ---
            RegisterText("guofengjia9", "国风·纹饰护甲六");
            RegisterText("guofengjia9_Desc", "国风装备系列：根据鸭星六级护甲改造。");

            // --- 装备 10: guofengtoukui1 ---
            RegisterText("guofengtoukui1", "国风·纹饰头盔五");
            RegisterText("guofengtoukui1_Desc", "国风装备系列：彩绘环绕头盔做装饰，在美学上出彩，不知防护如何。");

            // --- 装备 11: guofengjia10 ---
            RegisterText("guofengjia10", "国风·战术高级护甲");
            RegisterText("guofengjia10_Desc", "国风装备系列：在防护能力方面，战术和重型是否会有微妙的平衡点。");

            // --- 装备 12: guofengmj1 ---
            RegisterText("guofengmj1", "国风·傩戏面具");
            RegisterText("guofengmj1_Desc", "国风装备系列：这是一个非常特殊的面具，充满了中国的传统文化。");

            // --- 装备 13: guofengtoukui2 ---
            RegisterText("guofengtoukui2", "国风·纹饰头盔四");
            RegisterText("guofengtoukui2_Desc", "国风装备系列：兼顾美学和防护能力。");

            // --- 装备 14: guofengbeib1 ---
            RegisterText("guofengbeib1", "国风·高级战术背包");
            RegisterText("guofengbeib1_Desc", "国风装备系列：在战场中，背包是一种很重要的保障。");

            // --- 装备 15: guofengtoukui3 ---
            RegisterText("guofengtoukui3", "国风·纹饰头盔二");
            RegisterText("guofengtoukui3_Desc", "国风装备系列：美学和基础防护能力。");

            // --- 装备 16: guofengjzwuq1 ---
            RegisterText("guofengjzwuq1", "汉·环首刀");
            RegisterText("guofengjzwuq1_Desc", "国风装备系列：时代已远去，兵器意在战场。");
            
            // --- 装备 17: guofengjia11 ---
            RegisterText("guofengjia11", "国风·纹饰护甲四");
            RegisterText("guofengjia11_Desc", "国风装备系列：美学和不错防护能力。");

            // --- 装备 18: guofengjia13 ---
            RegisterText("guofengjia13", "国风·纹饰护甲一");
            RegisterText("guofengjia13_Desc", "国风装备系列：提供了基本的防护性能。");

            // --- 物品 1: guofengscp1 ---
            RegisterText("guofengscp1", "白·神采飞扬马");
            RegisterText("guofengscp1_Desc", "国风系列：丙午马年收藏品，通体白色陶瓷做成，犹如白玉一般的质感。");

            // --- 物品 2: guofengscp2 ---
            RegisterText("guofengscp2", "彩·神采飞扬马");
            RegisterText("guofengscp2_Desc", "国风系列：丙午马年收藏品，加入彩绘点缀，增添了一定的美感。");

            // --- 装备 19: guofengmj2 ---
            RegisterText("guofengmj2", "国风·威严面具");
            RegisterText("guofengmj2_Desc", "国风装备系列：这是一个心生恐惧的面具，战场上用来震慑敌人。");

            // --- 装备 20: guofengjia12 ---
            RegisterText("guofengjia12", "国风·纹饰高级护甲");
            RegisterText("guofengjia12_Desc", "国风装备系列：提供了各种承伤倍率属性，可是并没有风暴防护能力,纹饰环绕护甲。");
            
            // --- 装备 21: guofengjia15 ---
            RegisterText("guofengjia15", "国风·狮护甲四");
            RegisterText("guofengjia15_Desc", "国风装备系列：根据舞狮风格制作的护甲，威严霸气，防护性能并不很出色。");

            // --- 装备 22: guofengtoukui7 ---
            RegisterText("guofengtoukui7", "国风·狮头盔四");
            RegisterText("guofengtoukui7_Desc", "国风装备系列：根据舞狮风格制作的头盔，威严霸气。");

            // --- 装备 23: guofengtoukui5 ---
            RegisterText("guofengtoukui5", "国风·青铜头盔三");
            RegisterText("guofengtoukui5_Desc", "国风装备系列： 时代已远去，这是一个青铜的头盔，在美学上有一定的价值。");

            // --- 装备 24: guofengjzwuq2 ---
            RegisterText("guofengjzwuq2", "国风·大刀");
            RegisterText("guofengjzwuq2_Desc", "国风装备系列：时代已远去，兵器意在战场。");

            // --- 装备 25: guofengtoukui6 ---
            RegisterText("guofengtoukui6", "国风·青铜头盔一");
            RegisterText("guofengtoukui6_Desc", "国风装备系列： 时代已远去，这是一个青铜的头盔，防护能力如何？。");

            // --- 装备 26: guofengjia14 ---
            RegisterText("guofengjia14", "国风·纹饰终级护甲");
            RegisterText("guofengjia14_Desc", "国风装备系列：纹饰环绕护甲，这样一件护甲不知为何会在鸭星现世，提供了非常高的防护能力。");

            // --- 装备 27: guofengtoukui4 ---
            RegisterText("guofengtoukui4", "国风·纹饰终级头盔");
            RegisterText("guofengtoukui4_Desc", "国风装备系列：环绕头盔做的绝美装饰，可是出现的不是时候，如何驾驭它。");
            
            // --- 装备 28: guofengtoukui8 ---
            RegisterText("guofengtoukui8", "国风·明头盔五");
            RegisterText("guofengtoukui8_Desc", "国风装备系列：根据明代风格制作的头盔，并没有进行现代化改造，但还是提供了不错的防护性能。");

            // --- 装备 29: guofengtoukui9 ---
            RegisterText("guofengtoukui9", "国风·明头盔六");
            RegisterText("guofengtoukui9_Desc", "国风装备系列：根据明代风格制作的头盔，明代的基础版型，就给我们提供了不错的防护，根据时代变化做了一些改动。");

            // --- 装备 30: guofengbeib1.1 ---
            RegisterText("guofengbeib1.1", "国风·高级战术背包");
            RegisterText("guofengbeib1.1_Desc", "国风装备系列：在战场中，背包是一种很重要的保障，另一种色彩，另一种风格。");
                                                                        
            Debug.Log("[guofengzhuangbei] 中文本地化文本已注册 (LocalizationHelper)！");
        }

        private static void RegisterText(string key, string value)
        {
            // 使用反射调用 SodaCraft.Localizations.LocalizationManager.SetOverrideText
            // 以防缺少引用或在不同版本中命名空间变动
            
            var type = System.Type.GetType("SodaCraft.Localizations.LocalizationManager, SodaLocalization");
            if (type == null) type = System.Type.GetType("SodaCraft.Localizations.LocalizationManager, Assembly-CSharp");

            if (type != null)
            {
                var method = type.GetMethod("SetOverrideText", new System.Type[] { typeof(string), typeof(string) });
                if (method != null)
                {
                    method.Invoke(null, new object[] { key, value });
                }
                else
                {
                    Debug.LogError("[guofengzhuangbei] Cannot find method SetOverrideText");
                }
            }
            else
            {
                 Debug.LogError("[guofengzhuangbei] Cannot find LocalizationManager type");
            }
        }
    }
}