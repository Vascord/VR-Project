using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    bool triggered;
    public UnityEvent ExecuteFunction;

    public void OnTriggerEnter(Collider other)
    {
        if(!triggered)
        {
            triggered = true;
            ExecuteFunction.Invoke();
            triggered = false;
        }
    }
}
