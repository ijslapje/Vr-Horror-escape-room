using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverUp : MonoBehaviour
{
    public static bool lever1up;
    public static bool lever2up;
    public static bool lever3up;
    public static bool lever4up;
    public static bool lever5up;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "lever1")
        {
            lever1up = true;
        }

        if (collision.gameObject.tag == "lever2")
        {
            lever2up = true;
        }

        if (collision.gameObject.tag == "lever3")
        {
            lever3up = true;
        }

        if (collision.gameObject.tag == "lever4")
        {
            lever4up = true;
        }

        if (collision.gameObject.tag == "lever5")
        {
            lever5up = true;
        }
    }
}

