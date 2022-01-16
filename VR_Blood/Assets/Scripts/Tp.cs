using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    [SerializeField] private GameObject rig;
    
    [SerializeField] private GameObject tpobject;
    [SerializeField] private Animator fadeout;

    [SerializeField] private GameObject LocomotionSystem;
    [SerializeField] private GameObject OriginalRemy;
    [SerializeField] private GameObject NewRemy;
    [SerializeField] private GameObject NewXRRig;
    [SerializeField] private GameObject Leftknee;
    [SerializeField] private GameObject RightFoot;
    [SerializeField] private GameObject LeftFoot;
    [SerializeField] private BloodTime doctor;

    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    public void TpCharacter()
    {
        // rig.transform.position = tpobject.transform.position;
        
        NewRemy.SetActive(true);
        NewXRRig.SetActive(true);
        OriginalRemy.SetActive(false);
        LocomotionSystem.SetActive(false);
        rig.SetActive(false);
        doctor.ActivateBlood();
    }

    public void FadeOut()
    {
        fadeout.SetTrigger("FadeOut");
    }
}
