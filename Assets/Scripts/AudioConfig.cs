using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioConfig : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] AudioSource bgmAudioSource;
    [SerializeField] Slider bgmSlider;

    private void Start()
    {
        //何もスライダーを触らなかった場合
        PlayerPrefs.SetFloat("BGMVolume", 0);
        PlayerPrefs.Save();

        //スライダーを触ったら音量が変化する
        bgmSlider.onValueChanged.AddListener((value) => 
        { 

            value = Mathf.Clamp01(value);

            //変化するのは-80~0までの間
            float decibel = 20f * Mathf.Log10(value);
            decibel = Mathf.Clamp(decibel, -80f, 0f);

            Debug.Log("decibel" + decibel) ;

            //BGMの音量を保存
            PlayerPrefs.SetFloat("BGMVolume", decibel);
            PlayerPrefs.Save();

            audioMixer.SetFloat("BGM", decibel);
        });

    }
}
