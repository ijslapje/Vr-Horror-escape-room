using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverDown : MonoBehaviour
{

    public static bool lever1down;
    public static bool lever2down;
    public static bool lever3down;
    public static bool lever4down;
    public static bool lever5down;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "lever1")
        {
            lever1down = true;
        }

        if (collision.gameObject.tag == "lever2")
        {
            lever2down = true;
        }

        if (collision.gameObject.tag == "lever3")
        {
            lever3down = true;
        }

        if (collision.gameObject.tag == "lever4")
        {
            lever4down = true;
        }

        if (collision.gameObject.tag == "lever5")
        {
            lever5down = true;
        }
    }
}
