using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    [SerializeField] private GameObject rig;
    
    [SerializeField] private GameObject tpobject;
    [SerializeField] private Animator fadeout;

    [SerializeField] private GameObject Hips;
    [SerializeField] private GameObject LeftLeg;
    [SerializeField] private GameObject RightLeg;
    [SerializeField] private GameObject rightknee;
    [SerializeField] private GameObject Leftknee;
    [SerializeField] private GameObject RightFoot;
    [SerializeField] private GameObject LeftFoot;

    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    public void TpCharacter()
    {
        rig.transform.position = tpobject.transform.position;
        
    }

    public void FadeOut()
    {
        fadeout.Play("FadeOut");
    }
}
