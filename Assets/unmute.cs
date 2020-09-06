using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class unmute : MonoBehaviour

{
    public AudioMixer mixer;


    // Start is called before the first frame update
    void Start()
    {
        mixer.SetFloat("MusicVol2", 0);

    }

}

