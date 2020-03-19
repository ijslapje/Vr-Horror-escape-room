using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerLimit : MonoBehaviour
{
 // Update is called once per frame
    void Update()
    {
        //dit is voor debuggen. -----------------------------------|
        if(Input.GetKeyDown(KeyCode.I)){
            this.transform.Translate(new Vector3(0.1f, 0f, 0f));
        }
        else if(Input.GetKeyDown(KeyCode.K)){
            this.transform.Translate(new Vector3(-0.1f, 0f, 0f));
        }
        //DUS VERWIJDER HET ----------------------------------------|

        //dit is nogal gehacked. 
        var pos = this.transform.localPosition;
        pos.x =  Mathf.Clamp(this.transform.localPosition.x, this.transform.position.x-1, (this.transform.position.x-1) + this.transform.localScale.x / 2);
        this.transform.localPosition = pos;
    }
}
