using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTexture : MonoBehaviour
{
    Material M_material;
    public Texture[] tex;

    public bool symbol1;
    public bool symbol2;
    public bool symbol3;
    public bool symbol4;
    public bool symbol5;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (symbol1 == true)
        {
            M_material = gameObject.GetComponent<Renderer>().material;
            M_material.mainTexture = tex[SetRanTex.Tex1];
        }
        else if (symbol2 == true)
        {
            M_material = gameObject.GetComponent<Renderer>().material;
            M_material.mainTexture = tex[SetRanTex.Tex2];
        }
        else if (symbol3 == true)
        {
            M_material = gameObject.GetComponent<Renderer>().material;
            M_material.mainTexture = tex[SetRanTex.Tex3];
        }
        else if (symbol4 == true)
        {
            M_material = gameObject.GetComponent<Renderer>().material;
            M_material.mainTexture = tex[SetRanTex.Tex4];
        }
        else if (symbol5 == true)
        {
            M_material = gameObject.GetComponent<Renderer>().material;
            M_material.mainTexture = tex[SetRanTex.Tex5];
        }
    }
}
