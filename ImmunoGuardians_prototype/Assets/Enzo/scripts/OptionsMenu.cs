using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider; 
    public Slider brightnessSlider; 

    void Start()
    {
        float volume;
        audioMixer.GetFloat("Volume", out volume);
        volumeSlider.value = volume;

        float brightness = PlayerPrefs.GetFloat("Brightness", 1.0f);
        brightnessSlider.value = brightness;
        SetBrightness(brightness);
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetBrightness(float brightness)
    {
        RenderSettings.ambientLight = Color.white * brightness;
        PlayerPrefs.SetFloat("Brightness", brightness);
    }
}
