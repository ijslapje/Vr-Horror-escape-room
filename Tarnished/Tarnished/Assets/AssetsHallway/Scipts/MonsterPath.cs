using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MonsterPath : MonoBehaviour
{
    public Animator anim;
    public GameObject door;

    public Transform[] target;
    public float speed;

    private bool walking;
    private int current;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        walking = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(walking == true)
        {
            if (transform.position != target[current].position)
            {
                Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
                anim.SetBool("walking", true);
                GetComponent<Rigidbody>().MovePosition(pos);
            }
            else current = (current + 1) % target.Length;
        }

        if(current == 4)
        {
            walking = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "door")
        {
            door.GetComponent<Animator>().SetTrigger("Open");
        }
    }

}
