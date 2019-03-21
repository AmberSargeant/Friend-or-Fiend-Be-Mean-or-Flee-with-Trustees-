using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip Sound;
    public AudioSource SoundSource;
    // Start is called before the first frame update
    void Start()
    {
        SoundSource.clip = Sound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
