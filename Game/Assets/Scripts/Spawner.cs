using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour {

    public float time = 1;
    public bool repeat = false;
    public UnityEvent onTimerComplete;

    private void start()
    {
        if (repeat)
        {
            InvokeRepeating("OnTimerComplete", 0, time);
        }
        else
        {
            invoke("OnTimerComplete", time);
        }

    }
 
        private void OnTimerComplete()
        {
            onTimerComplete.Invoke();
        }
    
}
