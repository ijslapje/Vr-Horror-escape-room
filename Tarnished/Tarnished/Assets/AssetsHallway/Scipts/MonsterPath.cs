using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MonsterPath : MonoBehaviour
{
    public Animator anim;
    public AudioSource source;
    public AudioClip runSound;
    public AudioClip walkSound;

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
        speed = 0.6f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isWalking == true)
        {
            anim.SetBool("walking", true);
            source.clip = walkSound;
        }
        else if (isRunning == true)
        {
            anim.SetBool("running", true);
            source.clip = runSound;
        }

        if (isWalking == true)
        {
            if (transform.position != target[current].position)
            {
                Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
                GetComponent<Rigidbody>().MovePosition(pos);
                speed = 0.6f;
                source.loop = true;
                if (current == 2)
                {
                    anim.SetBool("walking", false);
                    source.volume = 0f;
                    speed = 0.2f;
                }
                else if (current != 2)
                {
                    anim.SetBool("walking", true);
                    source.volume = 0.7f;
                    speed = 0.6f;
                }
            }
            else current = (current + 1) % target.Length;
            if (current > 4)
            {
                source.Stop();
                Destroy(gameObject);
            }
        }

        if (isRunning == true)
        {

            if (transform.position != target[current].position)
            {
                Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
                GetComponent<Rigidbody>().MovePosition(pos);
                speed = 2;
                source.volume = 1;
                source.loop = true;
            }
            else current = (current + 1) % target.Length;
            if(current > 1)
            {
                Destroy(gameObject);
            }
        }
    }
}
