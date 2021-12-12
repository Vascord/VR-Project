using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    Animator animator;
    float gripTarget, triggerTarget, gripCurrent, triggerCurrent;
    float speed = 5;



    void Awake() => animator = GetComponent<Animator>();

    void Update() => AnimateHand();

    internal void SetGrip(float v) => gripTarget = v;

    internal void SetTrigger(float v) => triggerTarget = v;

    void AnimateHand()
    {
        if(gripCurrent != gripTarget)
        {
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * speed);
            animator.SetFloat("Grip", gripCurrent);
        }

        if(triggerCurrent != triggerTarget)
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * speed);
            animator.SetFloat("Trigger", triggerCurrent);
        }
    }

}
