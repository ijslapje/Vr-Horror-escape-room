using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickering : MonoBehaviour
{
    public Light light;
    public AudioSource source;

    public float timer;
    public float volume;
    public float lightIntens;
    public bool on;


    // Start is called before the first frame update
    void Start()
    {
        timer = 1f;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            if(on == true)
            {
                light.intensity = lightIntens;
                source.Play();
                source.volume = volume;
                on = false;
            }
            else if(on == false)
            {
                light.intensity = 0.0f;
                source.Pause();
                on = true;
            }
            timer = Random.Range(0, 0.6f);
            volume = Random.Range(0.3f, 0.5f);
            lightIntens = Random.Range(0.1f, 0.5f);
        }
    }
}
