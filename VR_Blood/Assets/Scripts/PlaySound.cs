using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioSource voice;

    // Start is called before the first frame update
    void PlayAudio()
    {
        voice.Play();
    }
}
