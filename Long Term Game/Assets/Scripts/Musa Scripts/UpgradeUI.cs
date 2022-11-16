using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UpgradeSystem
{
    public class UpgradeUI : MonoBehaviour
    {
        public int totalOrbs = 0;
        public UpgradeSaveScriptable upgradeData;
        public GameObject[] attackModels;
        public Text unlockBtnText, upgradeBtnText, levelText, magicNameText;
        public Text totalOrbsText;
        public Button unlockBtn, upgradeBtn, nextBtn, previousBtn;

        private int currentIndex = 0;
        private int selectedIndex = 0;

        private void Start()
        {
            selectedIndex = upgradeData.selectedIndex;
            currentIndex = selectedIndex;
            totalOrbsText.text = "" + totalOrbs;
            SetMagicInfo();

            unlockBtn.onClick.AddListener(() => UnlockSelectBtnMethod());
            upgradeBtn.onClick.AddListener(() => UpgradeBtnMethod());
            nextBtn.onClick.AddListener(() => NextBtnMethod());
            previousBtn.onClick.AddListener(() => PreviousBtnMethod());

            attackModels[currentIndex].SetActive(true);

            if (currentIndex == 0) previousBtn.interactable = false;
            if (currentIndex == upgradeData.upgradeItems.Length - 1) nextBtn.interactable = false;
        }

        private void SetMagicInfo()
        {
            magicNameText.text = upgradeData.upgradeItems[currentIndex].itemName;
            int currentLevel = upgradeData.upgradeItems[currentIndex].unlockedLevel;
            levelText.text = "Level:" + (currentLevel + 1);
        }

        public void NextBtnMethod()
        {
            if(currentIndex < upgradeData.upgradeItems.Length - 1)
            {
                attackModels[currentIndex].SetActive(false);
                currentIndex++;
                attackModels[currentIndex].SetActive(true);
                SetMagicInfo();

                if (currentIndex == upgradeData.upgradeItems.Length - 1) nextBtn.interactable = false;

                if (!previousBtn.interactable) previousBtn.interactable = true;
            }
        }

        public void PreviousBtnMethod()
        {
            if (currentIndex < 0)
            {
                attackModels[currentIndex].SetActive(false);
                currentIndex--;
                attackModels[currentIndex].SetActive(true);
                SetMagicInfo();

                if (currentIndex == upgradeData.upgradeItems.Length - 1) nextBtn.interactable = false;

                if (!previousBtn.interactable) previousBtn.interactable = true;
            }
        }

        private void UnlockSelectBtnMethod()
        {

        }

        private void UpgradeBtnMethod()
        {

        }
    }
}
