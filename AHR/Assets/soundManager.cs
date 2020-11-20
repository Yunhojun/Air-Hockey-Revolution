using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public AudioClip soundPingPong;
    public AudioClip soundDash;
    AudioSource myAudio;
    public static soundManager instance;
    void Awake()
    {
        if (soundManager.instance == null)
        {
            soundManager.instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        myAudio = this.gameObject.GetComponent<AudioSource>();
    }
    public void PlaySoundPingPong()
    {
        myAudio.PlayOneShot(soundPingPong);
    }
    public void PlaySoundDash()
    {
        myAudio.PlayOneShot(soundDash);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
