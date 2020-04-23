using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorAction : MonoBehaviour
{
    public GameObject doorclone;
    public GameObject door;
    public GameObject bedCollider;
    void PickVentUp()
    {
        doorclone.transform.gameObject.SetActive(true);
        door.transform.gameObject.SetActive(false);
        bedCollider.transform.gameObject.SetActive(false);
    }
}
