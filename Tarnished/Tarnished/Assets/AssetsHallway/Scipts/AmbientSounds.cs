using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSounds : MonoBehaviour
{
    public AudioSource AmbientSound;
    public AudioClip[] Ambient;

    // Start is called before the first frame update
    void Start()
    {
        AmbientSound = GetComponent<AudioSource>();
        CallAudio();
    }

    void CallAudio()
    {
        Invoke("RandomGrunt", 40);
    }

    void RandomGrunt()
    {
        AmbientSound.clip = Ambient [Random.Range(0, Ambient.Length)];
        AmbientSound.Play();
        CallAudio();
    }
}