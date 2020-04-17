using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levers : MonoBehaviour
{

    public GameObject lever1;
    public GameObject lever2;
    public GameObject lever3;
    public GameObject lever4;
    public GameObject lever5;

    public GameObject drawerClone;
    public GameObject drawerReal;

    public AudioSource source;
    public AudioClip drawerSound;
    public AudioClip leverUp;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lever1.transform.position.x == 0.34f || lever2.transform.position.x == 0.34f || lever3.transform.position.x == 0.34f
                || lever4.transform.position.x == 0.34f || lever5.transform.position.x == 0.34f)
        {
            source.pitch = 1;
            source.PlayOneShot(leverUp);
        }

        if (lever1.transform.position.x == 0.33f || lever2.transform.position.x == 0.33f || lever3.transform.position.x == 0.33f
        || lever4.transform.position.x == 0.33f || lever5.transform.position.x == 0.33f)
        {
            source.pitch = -1;
            source.PlayOneShot(leverUp);
        }

        {

            if (SetRanTex.ranCombi == 0)
        {
            if(lever1.transform.position.x >= 0.34f && lever2.transform.position.x >= 0.34f && lever3.transform.position.x <= 0.33f 
                && lever4.transform.position.x >= 0.34f && lever5.transform.position.x <= 0.33f)
            {
                drawerClone.gameObject.SetActive(false);
                drawerReal.gameObject.SetActive(true);
                source.PlayOneShot(drawerSound);
            }
        }

        if (SetRanTex.ranCombi == 1)
        {
            if (lever1.transform.position.x >= 0.34f && lever2.transform.position.x <= 0.33f && lever3.transform.position.x >= 0.34f
                && lever4.transform.position.x <= 0.33f && lever5.transform.position.x <= 0.33f)
            {
                drawerClone.gameObject.SetActive(false);
                drawerReal.gameObject.SetActive(true);
                source.PlayOneShot(drawerSound);
            }
        }

        if (SetRanTex.ranCombi == 2)
        {
            if (lever1.transform.position.x <= 0.33f && lever2.transform.position.x >= 0.34f && lever3.transform.position.x <= 0.33f
                && lever4.transform.position.x >= 0.34f && lever5.transform.position.x >= 0.34f)
            {
                drawerClone.gameObject.SetActive(false);
                drawerReal.gameObject.SetActive(true);
                source.PlayOneShot(drawerSound);
            }
        }
    }
}
