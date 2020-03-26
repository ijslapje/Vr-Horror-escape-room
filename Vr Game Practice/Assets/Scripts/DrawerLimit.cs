using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerLimit : MonoBehaviour
{

    // Update is called once per frame
    private void Start()
    {

    }

    void Update()
    {
        //dit is voor debuggen. -----------------------------------|
        if (Input.GetKeyDown(KeyCode.I))
        {
            this.transform.Translate(new Vector3(0.1f, 0f, 0f));
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            this.transform.Translate(new Vector3(-0.1f, 0f, 0f));
        }
        //DUS VERWIJDER HET ----------------------------------------|


        ////dit is nogal gehacked. 
        //var pos = this.transform.localPosition;
        //pos.x = Mathf.Clamp(this.transform.localPosition.x, this.transform.position.x - 1, (this.transform.position.x - 1) + this.transform.localScale.x / 2);
        //this.transform.localPosition = pos;
        this.transform.rotation = Quaternion.Euler(-90f, 0f, -90f);

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
