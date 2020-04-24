using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screwYou : MonoBehaviour
{
    public Collider coll;
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
