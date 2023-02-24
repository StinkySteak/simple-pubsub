using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSignalSubscriber : MonoBehaviour
{
    private void Start()
    {
        SignalManager.Instance.Subscribe<LogSignal>(OnLogged);
    }
    private void OnLogged(LogSignal signal)
    {
        print($"Log: {signal}");
    }
}
