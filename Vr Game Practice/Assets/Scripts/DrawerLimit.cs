using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerLimit : MonoBehaviour
{
    void Update()
    {
        ////dit is voor debuggen. -----------------------------------|
        //if (Input.GetKeyDown(KeyCode.I))
        //{
        //    this.transform.Translate(new Vector3(0.1f, 0f, 0f));
        //}
        //else if (Input.GetKeyDown(KeyCode.K))
        //{
        //    this.transform.Translate(new Vector3(-0.1f, 0f, 0f));
        //}
        ////pp poopoo -----------------------------------------------|


        this.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);

        DrawerSpace();

    }

    void DrawerSpace()
    {
        if (this.transform.localPosition.x > 0.225)
        {
            this.transform.localPosition = new Vector3(0.224f, 0f, 0f);
        }
        else if (this.transform.localPosition.x < 0)
        {
            this.transform.localPosition = new Vector3(0f, 0f, 0f);
        }
    }
}
