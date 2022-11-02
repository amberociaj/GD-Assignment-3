using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UpgradeSystem
{
    [CreateAssetMenu(fileName = "UpgradeData",menuName = "Scriptable/CreateUpgradeData")]
    public class UpgradeSaveScriptable : ScriptableObject
    {
        public UpgradeItem[] upgradeItems;
    }

    [System.Serializable]
    public class UpgradeItem
    {
        public string itemName;
        public bool isUnlocked;
        public int unlockCost;
        public int unlockedLevel;
        public AttackInfo[] attackLevel;
    }

    [System.Serializable]
    public class AttackInfo
    {
        public int unlockCost;
        public int Attacklevel;
    }
}
