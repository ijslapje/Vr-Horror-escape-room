using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MonsterPath : MonoBehaviour
{
    public Animator anim;

    public Transform[] target;
    public float speed;

    private int currentpos;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != target[currentpos].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[currentpos].position, speed * Time.deltaTime);
            Vector3 rot = Vector3.RotateTowards(pos, target[currentpos].position, speed * Time.deltaTime, 90f); 
            GetComponent<Rigidbody>().MovePosition(pos);
            anim.SetBool("walking", true);
        }
        else if(transform.position == target[currentpos].position)
        {
            currentpos = (currentpos + 1) % target.Length;
        }
    }
}
