using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beforeDrawer : MonoBehaviour
{
    public GameObject drawer;
    public GameObject clone;

    // Update is called once per frame
    void Update()
    {
        if(OnCollision.opslot == false)
        {
            drawer.transform.gameObject.SetActive(true);
            clone.transform.gameObject.SetActive(false);
        }
    }
}
