using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingTime : MonoBehaviour
{
    public float maxTime;
    [SerializeField] private float refreshTime;
    [SerializeField] private Animator doorAnimation;
    private float time = 0;
    private bool activate;
    private float period = 0;

    // Update is called once per frame
    void Update()
    {
        if(activate)
        {
            if (period > refreshTime)
            {
               
                time++;

                if (time >= maxTime)
                {
                    
                    doorAnimation.SetBool("OpenClose", true);
                    Destroy(gameObject);
                }
                
                period = 0;
            }

            period += Time.deltaTime;
        }
    }

    public void ActivateTimer()
    {
        activate = true;
    }
}
