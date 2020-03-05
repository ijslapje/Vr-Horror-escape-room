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
        if(Input.GetButtonDown("1key")){
            VRcam.SetActive(true);
            mouseCam.SetActive(false);
        }
        else if(Input.GetButtonDown("2key")){
            VRcam.SetActive(false);
            mouseCam.SetActive(true);
        }
    }
}
