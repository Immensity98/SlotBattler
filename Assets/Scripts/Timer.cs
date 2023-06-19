using JetBrains.Annotations;
using System;
using System.Collections;
using UnityEditor.Search;
using UnityEngine;
using VContainer;

public class Timer
{
    private float _currentTime;
    private float _coroutineDelay = 1;
    private Dispatcher _dispatcher;
    private IEnumerator _coroutine;

    public float RoundDuration { get; private set; }
    public Action TimeEnd;

    public Timer(Dispatcher dispatcher, float roundDuration)
    {
        _coroutine = RoundTimeCheck();
        _dispatcher = dispatcher;
        RoundDuration = roundDuration;
    }

    public IEnumerator RoundTimeCheck()
    {
        _currentTime = RoundDuration;

        while (true)
        {
            yield return new WaitForSeconds(_coroutineDelay);

            _currentTime -= 1;
            Debug.Log("Current time = " + _currentTime);

            if (_currentTime <= 0)
            {
                EndTimer();
                yield break;
            }
        }
    }

    public void StartTimer()
    {
        Debug.Log("StartTimer");
        _dispatcher.StartCoroutine(_coroutine);
    }

    public void EndTimer()
    {
        Debug.Log("EndTimer");
        TimeEnd?.Invoke();
    }

    public void PauseTimer()
    {
        Debug.Log("Pause");
        _dispatcher.StopCoroutine(_coroutine);
    }

    public void RestartTimer()
    {
        Debug.Log("Restart");
        _dispatcher.StopCoroutine(_coroutine);
        _currentTime = RoundDuration;
        StartTimer();
    }

    public void ResetTimer()
    {
        Debug.Log("Reset");
        _dispatcher.StopCoroutine(_coroutine);
        _currentTime = RoundDuration;
    }
}
