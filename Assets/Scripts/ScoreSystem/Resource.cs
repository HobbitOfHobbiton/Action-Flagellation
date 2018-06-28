using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScoreSystem
{
    public abstract class Resource : MonoBehaviour
    {
        [SerializeField] protected float _maxAmount;
        [SerializeField] protected static float _currentAmount;
        [SerializeField] protected float _passiveGainRatio;

        public float MaxAmount
        {
            get { return _maxAmount; }
        }

        public static float CurrentAmount
        {
            get { return _currentAmount; }
        }

        public float PassiveGainRatio
        {
            get { return _passiveGainRatio; }
        }

        //-------------------------------------------

        protected virtual void Start()
        {
            _currentAmount = _maxAmount;
        }

        protected virtual void Update()
        {
            if (_currentAmount < _maxAmount)
                _currentAmount += Time.deltaTime * _passiveGainRatio;
        }

        public void SetPassiveGainRatio(float ratio)
        {
            _passiveGainRatio = ratio;
        }

        public static void DecreaseResource(float amount)
        {
            _currentAmount -= amount;
        }
    }
}
