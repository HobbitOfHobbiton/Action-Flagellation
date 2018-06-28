using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

namespace ActionSystem
{
    public class ActionManager : MonoBehaviour
    {
        [SerializeField] private Flagellation _flagellationAction;
        [SerializeField] private ParticleSystem _particleSystem;

        private Animator _animator;

        void Start()
        {
            _animator = GetComponent<Animator>();
            _flagellationAction.Init(_animator);
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0) && Sins.CurrentAmount > 0 && !ShopManager.shopping)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray, out hit))
                {
                    if(hit.transform.tag == "Penitent")
                    {
                        _flagellationAction.Use();
                    }
                }

            }
        }

        public void Hit()
        {
            _flagellationAction.FlagellationHit(_particleSystem);
        }
    }
}
