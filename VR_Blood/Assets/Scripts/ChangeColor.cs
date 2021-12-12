using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    bool changeColor;
    public void ExampleFunction()
    {
        changeColor = !changeColor;
        if (changeColor)
            GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
        else
            GetComponent<MeshRenderer>().material.SetColor("_Color", Color.white);
    }
}
