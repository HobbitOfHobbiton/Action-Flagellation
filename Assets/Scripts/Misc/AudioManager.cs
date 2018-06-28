using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    private static AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public static void PlayAudioClip(float minPitch, float maxPitch)
    {
        _audioSource.pitch = Random.Range(minPitch, maxPitch);
        _audioSource.Play();
    }

}
