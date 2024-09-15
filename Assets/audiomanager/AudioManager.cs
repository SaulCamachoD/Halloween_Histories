using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public Sound[] musicSounds, sfxSounds, narratorSound;
    public AudioSource musicSource, sfxSource, narratorSource;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    public void PlayMusic(string name)
    {
        musicSource.Stop();

        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            //musicSource.Stop(); // Detener el clip actual
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            //sfxSource.Stop(); // Detener el clip actual
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void PlayNarrator(string name)
    {
        narratorSource.Stop();
        Sound s = Array.Find(narratorSound, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            //sfxSource.Stop(); // Detener el clip actual
            narratorSource.PlayOneShot(s.clip);
        }
    }

    // UI Sound Controls
    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }

    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute;
    }

    public void ChangeMusic(string sceneName)
    {
        switch (sceneName)
        {
            case "Menu":
                PlayMusic("Menu");
                break;
            case "Birthday":
                PlayMusic("Cuarto");
                break;
            case "Level1":
                PlayMusic("Puerta1");
                break;
            case "Level2": 
                PlayMusic("Puerta2");
                break;
            case "Level3":
                PlayMusic("Puerta3");
                break;
        }
    }
}