using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    [SerializeField] private GameObject rig;
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    public void TpCharacter()
    {
        rig.transform.position = new Vector3(x,y,z);
    }

}
