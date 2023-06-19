using System.Collections;
using UnityEngine;

public class Dispatcher : MonoBehaviour
{
    public Dispatcher Dispatchers;
    private Timer _timer;
    private void Start()
    {
        _timer = new Timer(Dispatchers, 5);
        _timer.StartTimer();
        
        StartCoroutine(Test());

    }

    


    IEnumerator Test()
    {
        yield return new WaitForSeconds(2);
        _timer.ResetTimer();
    }
}
