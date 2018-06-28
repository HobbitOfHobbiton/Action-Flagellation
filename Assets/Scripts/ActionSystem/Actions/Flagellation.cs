using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

namespace ActionSystem
{
    [CreateAssetMenu(fileName = "Flagellation", menuName = "Create Flagellation Action")]
    public class Flagellation : Action
    {
        public override void Init(Animator animator)
        {
            base.Init(animator);
        }

        public override void UpdateAction()
        {
            base.UpdateAction();
        }

        public override void Use()
        {
            base.Use();
            _animator.SetTrigger("Flagellation");
        }

        public void FlagellationHit(ParticleSystem particleSystem)
        {
            particleSystem.Emit(1);

            ScoreManager.AddScore(1);
            AudioManager.PlayAudioClip(1.0f, 1.4f);
            CameraShaker.Shake(5);

            Sins.DecreaseResource(10);
        }

    }
}
