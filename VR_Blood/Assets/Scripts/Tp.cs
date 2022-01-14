using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    [SerializeField] private GameObject rig;
    [SerializeField] private GameObject tpobject;
    [SerializeField] private Animator fadeout;

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
