using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 5.0f;

    private void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
    }

}
