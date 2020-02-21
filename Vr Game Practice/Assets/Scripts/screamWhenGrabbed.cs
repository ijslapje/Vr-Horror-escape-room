using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screamWhenGrabbed : MonoBehaviour
{
    private OVRGrabbable ovrGrabbable;
    public OVRInput.Button pressButton;
    public AudioClip scream;
    
    // Start is called before the first frame update
    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ovrGrabbable.isGrabbed && OVRInput.GetDown(pressButton, ovrGrabbable.grabbedBy.GetController())){

            VibrationManager.singleton.TriggerVibration(scream, ovrGrabbable.grabbedBy.GetController());

            GetComponent<AudioSource>().PlayOneShot(scream);
        }
    }
}
