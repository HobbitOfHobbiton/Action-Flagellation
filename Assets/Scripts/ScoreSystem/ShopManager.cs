using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ScoreSystem
{
    public class ShopManager : MonoBehaviour
    {
        [SerializeField] private ShoppingItem _scoreMultiplierItem;
        public static bool shopping;

        void Start()
        {
            
        }


        void Update()
        {

        }

        public void ToggleShop(bool enable)
        {
            shopping = enable;
            _scoreMultiplierItem.UpdateItem(ScoreManager.ScoreMultiplier);
            ScoreManager.SaveValues();
        }

        public void UpgradeMultiplier()
        {
            if (ScoreManager.Score >= _scoreMultiplierItem.Price)
            {
                ScoreManager.SetScoreMultiplier(ScoreManager.ScoreMultiplier + 1);
                ScoreManager.RemoveScore(_scoreMultiplierItem.Price);

                _scoreMultiplierItem.UpdateItem(ScoreManager.ScoreMultiplier);
            }
        }
    }
}
