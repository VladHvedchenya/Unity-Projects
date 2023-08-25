using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Alarm : MonoBehaviour
{
    [SerializeField] private float _step;
    [SerializeField] private float _delay;

    private float _minValue = 0;
    private float _maxValue = 1;

    private AudioSource _audio;
    private Coroutine _coroutine;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _audio.volume = _minValue;
    }

    public void TurnOn()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _audio.Play();
        _coroutine = StartCoroutine(Alarming(_maxValue));
    }

    public void TurnOff()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(Alarming(_minValue));
    }

    private IEnumerator Alarming(float targetValue)
    {
        var wait = new WaitForSeconds(_delay);

        while (enabled)
        {
            _audio.volume = Mathf.MoveTowards(_audio.volume, targetValue, _step);

            yield return wait;
        }

        if (_audio.volume == _minValue)
            _audio.Stop();
    }
}