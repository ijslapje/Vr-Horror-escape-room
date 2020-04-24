using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSounds : MonoBehaviour
{
    public AudioSource gruntSound;
    public AudioClip[] grunts;

    // Start is called before the first frame update
    void Start()
    {
        gruntSound = GetComponent<AudioSource>();
        CallAudio();
    }

    void CallAudio()
    {
        Invoke("RandomGrunt", Random.Range(5, 10));
    }

    void RandomGrunt()
    {
        gruntSound.clip = grunts [Random.Range(0, grunts.Length)];
        gruntSound.Play();
        CallAudio();
    }
}
