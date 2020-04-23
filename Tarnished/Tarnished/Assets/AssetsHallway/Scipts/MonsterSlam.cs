using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MonsterSlam : MonoBehaviour
{

    public AudioSource source;
    public AudioClip scream;
    public AudioClip Door;
    public Animator anim;

    public bool doorOpen;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        source.loop = true;
        anim.SetBool("slam", true);
    }

    public void VentOpen()
    {
        source.Stop();
        doorOpen = true;
        anim.SetBool("scream", true);
        source.PlayOneShot(Door);
        source.PlayOneShot(scream);
    }
}
