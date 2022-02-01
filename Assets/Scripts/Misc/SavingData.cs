using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SavingData : MonoBehaviour
{
    public AudioMixer Mixer;
    public Slider MasterSlider;
    public Slider MusicSlider;
    public Slider SfxSlider;
    public Slider AmbianceSlider;

    void Start()
    {
        MasterSlider.value = PlayerPrefs.GetFloat("MasterVol");
        MusicSlider.value = PlayerPrefs.GetFloat("MusicVol");
        SfxSlider.value = PlayerPrefs.GetFloat("SFXVol");
        AmbianceSlider.value = PlayerPrefs.GetFloat("AmbianceVol");

    }

    public void SetMasterVolume(float MasterVolume)
    {
        PlayerPrefs.SetFloat("MasterVol", MasterVolume);
        Mixer.SetFloat("MasterVol", Mathf.Log10(MasterVolume) * 20);
        PlayerPrefs.Save();
    }


    public void SetMusicVolume(float MusicVolume)
    {
        PlayerPrefs.SetFloat("MusicVol", MusicVolume);
        Mixer.SetFloat("MusicVol", Mathf.Log10(MusicVolume) * 20);
        PlayerPrefs.Save();
    }

    public void SetSFXVolume(float SFXVolume)
    {
        PlayerPrefs.SetFloat("SFXVol", SFXVolume);
        Mixer.SetFloat("SFXVol", Mathf.Log10(SFXVolume) * 20);
        PlayerPrefs.Save();
    }

    public void SetAmbianceVolume(float AmbianceVolume)
    {
        PlayerPrefs.SetFloat("AmbianceVol", AmbianceVolume);
        Mixer.SetFloat("AmbianceVol", Mathf.Log10(AmbianceVolume) * 20);
        PlayerPrefs.Save();
    }





}