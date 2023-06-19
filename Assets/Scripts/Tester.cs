using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    Dispatcher Dispatcher;



    private void Start()
    {
        Dispatcher = new Dispatcher();
        Debug.Log(Dispatcher);
    }
}
