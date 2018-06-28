using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ScoreSystem
{
    public class Sins : Resource
    {
        [SerializeField] private Image _sinBar;

        protected override void Start()
        {
            base.Start();
        }

        protected override void Update()
        {
            base.Update();

            _sinBar.fillAmount = _currentAmount / _maxAmount;
        }
    }
}
