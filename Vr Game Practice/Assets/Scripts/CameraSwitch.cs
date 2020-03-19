using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject VRcam;
    public GameObject mouseCam;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            VRcam.SetActive(true);
            mouseCam.SetActive(false);
        }
        else if(Input.GetKeyDown(KeyCode.W)){
            VRcam.SetActive(false);
            mouseCam.SetActive(true);
        }
    }
}
