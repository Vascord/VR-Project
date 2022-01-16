using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField] private bool destroyOrNot;
    [SerializeField] private bool door;
    [SerializeField] private Animator objectAnimation;
    [SerializeField] private bool closeOnly;
    [SerializeField] private CanvasGroup interfaceThing;
    [SerializeField] private Animator fade;
    [SerializeField] private bool interfaceCheck;
    [SerializeField] private float transitionSpeed;
    [SerializeField] private float transitionTimeSpeed;

    bool triggered;
    public UnityEvent ExecuteFunction;

    public void OnTriggerEnter(Collider other)
    {
        if(!triggered && other.gameObject.CompareTag("Player"))
        {

            triggered = true;
            ExecuteFunction.Invoke();
            triggered = false;
            if(door && !closeOnly)
            {

                objectAnimation.SetBool("OpenClose", true);
            }
            if (interfaceCheck)
            {
                fade.SetTrigger("FadeIn");
            }
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && door)
        {

            objectAnimation.SetBool("OpenClose", false);
        }
        if (destroyOrNot)
        {

            Destroy(gameObject);
        }
    }
}
