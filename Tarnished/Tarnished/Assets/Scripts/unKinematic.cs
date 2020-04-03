using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unKinematic : MonoBehaviour
{
    public GameObject gameObject;

    public void Turnoff()
    {
        Rigidbody cubeRigidbody = gameObject.GetComponent<Rigidbody>();
        cubeRigidbody.isKinematic = false;
    }
}
