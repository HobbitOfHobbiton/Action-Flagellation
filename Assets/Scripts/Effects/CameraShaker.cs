using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    [SerializeField] private float _shakeSpeed = 10.0f;
    [SerializeField] private float _shakeDecay = 5.0f;

    private static float _shakeAmplitude;

    [SerializeField] private float _guiShakeMultiplier = 0.25f;
    [SerializeField] private RectTransform _canvas;

    private Vector3 _cameraEuler;

    private void Start()
    {
        _cameraEuler = transform.localRotation.eulerAngles;
    }

    private void Update ()
    {
        _shakeAmplitude = Mathf.SmoothStep(_shakeAmplitude, 0.0f, Time.deltaTime * _shakeDecay);

        float bx = (Mathf.PerlinNoise(0, Time.time * _shakeSpeed) - 0.5f);
        float by = (Mathf.PerlinNoise(0, (Time.time * _shakeSpeed) + 100)) - 0.5f;

        bx *= _shakeAmplitude;
        by *= _shakeAmplitude;

        Vector2 _shake = new Vector2(bx, by);
        transform.localRotation = Quaternion.Euler(new Vector3( _shake.x, _shake.y,  _shake.magnitude) + _cameraEuler);
        _canvas.localPosition = new Vector3(_shake.y * _guiShakeMultiplier, _shake.x * _guiShakeMultiplier, 0);
    }

    public static void Shake(float shakeAmount)
    {
        _shakeAmplitude = shakeAmount;
    }
}
