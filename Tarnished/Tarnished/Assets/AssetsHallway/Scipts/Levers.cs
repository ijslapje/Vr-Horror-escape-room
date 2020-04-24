using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levers : MonoBehaviour
{
    public GameObject drawerClone;
    public GameObject drawerReal;

    public AudioSource source;
    public AudioClip drawerSound;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (SetRanTex.ranCombi == 0)
        {
            if (leverUp.lever1up == true && leverUp.lever2up == true && leverDown.lever3down == true && leverUp.lever4up == true && leverDown.lever5down == true)
            {
                drawerClone.gameObject.SetActive(false);
                drawerReal.gameObject.SetActive(true);
            }
        }

        if (SetRanTex.ranCombi == 1)
        {
            if(leverUp.lever1up == true && leverDown.lever2down == true && leverUp.lever3up == true && leverDown.lever4down == true && leverDown.lever5down == true)
            {
                drawerClone.gameObject.SetActive(false);
                drawerReal.gameObject.SetActive(true);
            }
        }

        if (SetRanTex.ranCombi == 2)
        {
            if (leverDown.lever1down == true && leverUp.lever2up == true && leverDown.lever3down == true && leverUp.lever4up == true && leverUp.lever5up == true)
            {
                drawerClone.gameObject.SetActive(false);
                drawerReal.gameObject.SetActive(true);
            }
        }
    }
}
