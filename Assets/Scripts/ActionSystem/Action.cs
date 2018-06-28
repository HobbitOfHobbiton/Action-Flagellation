using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActionSystem
{
    public abstract class Action : ScriptableObject
    {
        protected Animator _animator;

        public virtual void Init(Animator animator)
        {
            _animator = animator;
        }

        public virtual void UpdateAction()
        {

        }

        public virtual void Use()
        {

        }
    }
}
