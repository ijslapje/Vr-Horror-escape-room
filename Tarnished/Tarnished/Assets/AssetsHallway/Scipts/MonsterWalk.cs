using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MonsterWalk : MonoBehaviour
{
    public float speed;
    public bool walking;
    public bool running;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);

        if (walking == true)
        {
            speed = 0.003f;
            anim.SetBool("walking", true);
            transform.Translate(0, 0, speed);
        }
        else if (walking == false)
        {
            speed = 0;
            anim.SetBool("walking", false);
        }
        if (running == true)
        {
            speed = 0.03f;
            anim.SetBool("running", true);
        }
        else if(running == false)
        {
            speed = 0;
            anim.SetBool("running", false);
        }


        if(Input.GetKeyDown(KeyCode.A))
        {
            walking = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            walking = false;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            running = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            running = false;
        }

    }
}
