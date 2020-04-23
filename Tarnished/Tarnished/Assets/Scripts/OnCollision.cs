using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public Collider coll;
    public static bool opslot;

    void Start()
    {
        coll = GetComponent<Collider>();
        opslot = true;
    }

    // Disables gravity on all rigidbodies entering this collider.
    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
            other.attachedRigidbody.isKinematic = false;

            opslot = false;


    }
}
