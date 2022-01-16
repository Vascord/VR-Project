using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodTime : MonoBehaviour
{
    [SerializeField] private float maxTime;
    [SerializeField] private float refreshTime;
    [SerializeField] private float maxTimeEnd;
    [SerializeField] private float refreshTimeEnd;
    [SerializeField] private Animator blood;
    [SerializeField] private AudioSource voice1;
    [SerializeField] private AudioSource voice2;
    private bool activate;
    private bool end;
    private float period = 0;
    private float time = 0;

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
                    
                    GetComponent<Animator>().SetTrigger("Blood");
                    activate = false;
                    time = 0;
                }
                
                period = 0;
            }

            period += Time.deltaTime;
        }

        if(end)
        {
            if (period > refreshTimeEnd)
            {
               
                time++;

                if (time >= maxTime)
                {
                    Application.Quit();
                }
                
                period = 0;
            }

            period += Time.deltaTime;
        }
    }

    public void ActivateBlood()
    {
        activate = true;
        voice1.Play();
    }

    public void GettingBlood()
    {
        blood.SetTrigger("Blood");
    }

    public void GettingEnd()
    {
        GetComponent<Animator>().SetTrigger("Ending");
        end = true;
        voice2.Play();
    }
}
