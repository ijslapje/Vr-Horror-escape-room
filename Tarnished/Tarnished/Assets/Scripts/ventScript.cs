using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventScript : MonoBehaviour
{
    public GameObject ventclone;
    public GameObject vent;
    public static bool screwtup;

    void Start()
    {
        screwtup = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("screw").Length < 1)
        {
            Debug.Log("No more screws");
            screwtup = false;
        }

        if (screwtup == false)
        {
            ventclone.transform.gameObject.SetActive(false);
            vent.transform.gameObject.SetActive(true);
        }
    }
}
