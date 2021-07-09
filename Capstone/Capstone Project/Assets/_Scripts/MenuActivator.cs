using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class TriggerEvent : UnityEvent { }
public class MenuActivator : MonoBehaviour
{
    public TriggerEvent OnTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            OnTrigger.Invoke();
        }
    }
}
