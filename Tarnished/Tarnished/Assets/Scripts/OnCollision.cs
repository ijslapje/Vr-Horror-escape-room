using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public Collider coll;

    void Start()
    {
        coll = GetComponent<Collider>();
    }

    // Disables gravity on all rigidbodies entering this collider.
    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = true;
            other.attachedRigidbody.isKinematic = false;
    }
}
