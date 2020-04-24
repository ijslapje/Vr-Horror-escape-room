using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatAmn : MonoBehaviour
{
    public GameObject ratclone;
    public GameObject ratanm;

    // Update is called once per frame
    void Update()
    {
        if(this.transform.localPosition.x > 0.068)
        {
            ratanm.transform.gameObject.SetActive(true);
            ratclone.transform.gameObject.SetActive(false);
        }
    }
}
