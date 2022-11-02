using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    public static AudioSettings audioSettings;

    [Header("Information - Read Only from inspector")]
    [SerializeField]
    private float musicVolume;
  

    float musicDefaultVolume=0.7f;
    

    string musicAudioSourcesTag ="Music-AudioSource";


    string musicVolumeDataName = "music-volume";
    

    List<AudioSource> musicAudioSources;
   

    [SerializeField]
    private int musicAudioSourcesCount=0;
    

    private void Awake()
    {
        audioSettings = this;
        musicAudioSources = new List<AudioSource>();
        
        LoadSavedSettings();
    }

    void LoadSavedSettings()
    {
        musicVolume = PlayerPrefs.GetFloat(musicVolumeDataName,musicDefaultVolume);
        

    }

    public void ChangeMusicVolume(float newVolume)
    {
        musicVolume = newVolume;
        PlayerPrefs.SetFloat(musicVolumeDataName, musicVolume);
        SetVolumeToAudioSources(musicAudioSources, musicVolume);
    }


    

    void SetVolumeToAudioSources(List<AudioSource> audioSources, float volume)
    {
        foreach (AudioSource a in audioSources)
        {
            a.volume = volume;
        }
    }


    public float GetMusicVolume()
    {
        return musicVolume;
    }
  

    public void AddMeToMusicAudioSources(AudioSource a)
    {
        musicAudioSources.Add(a);
        musicAudioSourcesCount = musicAudioSources.Count;
    }

    public void RemoveMeFromMusicAudioSources(AudioSource a)
    {
        musicAudioSources.Remove(a);
        musicAudioSourcesCount = musicAudioSources.Count;
    }
  


}
