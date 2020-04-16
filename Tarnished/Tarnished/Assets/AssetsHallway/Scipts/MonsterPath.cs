using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MonsterPath : MonoBehaviour
{
    public Animator anim;
    public AudioSource source;

    public Transform[] target;
    public float speed;

    public bool isWalking;
    public bool isRunning;

    public int targetMaxSize;

    private bool walking;
    private int current;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        walking = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isWalking == true)
        {
            anim.SetBool("walking", true);
        }
        else if(isRunning == true)
        {

            anim.SetBool("running", true);
        }

        if(walking == true)
        {
            if (transform.position != target[current].position)
            {
                Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
                GetComponent<Rigidbody>().MovePosition(pos);
                source.loop = true;
                if (current == 2)
                {
                    anim.SetBool("walking", false);
                    source.volume = 0f;
                    speed = 0.1f;
                }
                else if (current != 2)
                {
                    anim.SetBool("walking", true);
                    source.volume = 0.7f;
                    speed = 1f;
                }
            }
            else current = (current + 1) % target.Length;
        }

        if (current > 4)
        {
            walking = false;
            source.Stop();
        }
    }

}
