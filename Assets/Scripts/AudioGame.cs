using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioGame : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer_Game;
    [SerializeField] AudioSource bgmAudioSource_Game;

    void Start()
    {
        float decibel = PlayerPrefs.GetFloat("BGMVolume");

        Debug.Log("ゲームのdecibel" + decibel) ;

        audioMixer_Game.SetFloat("BGM", decibel);
    }
}
