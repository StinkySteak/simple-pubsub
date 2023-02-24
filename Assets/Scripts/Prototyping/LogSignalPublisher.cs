using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSignalPublisher : MonoBehaviour
{
    [SerializeField] private string _message;

    private void Start()
    {
        SignalManager.Instance.Publish(new LogSignal() { Message = _message });
    }
}
