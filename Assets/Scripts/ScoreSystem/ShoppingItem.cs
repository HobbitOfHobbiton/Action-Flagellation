using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ScoreSystem
{
    [System.Serializable]
    public class ShoppingItem
    {
        [SerializeField] private Text _currentAmountText;
        [SerializeField] private Text _priceText;

        private uint _currentAmount;
        private uint _price;

        public uint Price
        {
            get { return _price; }
        }

        public void UpdateItem(uint currentAmount)
        {
            UpdateValues(currentAmount);
            UpdateTexts();
        }

        void UpdateValues(uint currentAmount)
        {
            _currentAmount = currentAmount;
            _price = (uint) ((4 * Mathf.Pow(_currentAmount + 1, 3) / 4));
            _price *= 5;
        }

        void UpdateTexts()
        {
            _currentAmountText.text = _currentAmount.ToString();
            _priceText.text = _price.ToString();
        }
    }
}
