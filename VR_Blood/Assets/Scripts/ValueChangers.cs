using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class ValueChangers : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer = default;
    [SerializeField] private WaitingTime time = default;
    [SerializeField] private Slider volumeASlider = default;
    [SerializeField] private Slider volumeCSlider = default;
    [SerializeField] private Slider timeSlider = default;

    // Start is called before the first frame update
    void Start()
    {
        // Adjust the slider to the actual volume of the game.
        float audioA;
        audioMixer.GetFloat("volumeA", out audioA);
        volumeASlider.value = audioA;

        float audioC;
        audioMixer.GetFloat("volumeI", out audioC);
        volumeCSlider.value = audioC;

        timeSlider.value = time.maxTime;
    }

    public void SetVolumeAmbience(float volume)
    {
        audioMixer.SetFloat("volumeA", volume);
    }

    public void SetVolumeCharacters(float volume)
    {
        audioMixer.SetFloat("volumeI", volume);
    }

    public void SetTime(float value)
    {
        time.maxTime = value;
    }
}
