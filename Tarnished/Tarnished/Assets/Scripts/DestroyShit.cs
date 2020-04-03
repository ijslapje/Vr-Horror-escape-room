using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShit : MonoBehaviour
{
    public void Destroy()
    {
        Destroy(GameObject.Find("holdLantern"));
        Destroy(this);
    }
}
