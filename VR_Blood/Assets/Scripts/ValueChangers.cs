using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class ValueChangers : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer = default;
    [SerializeField] private WaitingTime time = default;
    [SerializeField] private Slider volumeSlider = default;
    [SerializeField] private Slider timeSlider = default;

    // Start is called before the first frame update
    void Start()
    {
        // Adjust the slider to the actual volume of the game.
        float audio;
        audioMixer.GetFloat("volume", out audio);
        volumeSlider.value = audio;

        timeSlider.value = time.maxTime;
    }

    public void SetVolumeInterraction(float volume)
    {
        audioMixer.SetFloat("volumeI", volume);
    }

    public void SetVolumeAmbience(float volume)
    {
        audioMixer.SetFloat("volumeA", volume);
    }

    public void SetTime(float value)
    {
        time.maxTime = value;
    }
}
