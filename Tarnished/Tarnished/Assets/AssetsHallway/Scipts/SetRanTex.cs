using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRanTex : MonoBehaviour
{
    public GameObject symbol1;

    Material M_material;
    public Texture[] texCombi;
    public static int ranCombi;

    public static int Tex1;
    public static int Tex2;
    public static int Tex3;
    public static int Tex4;
    public static int Tex5;

    // Start is called before the first frame update
    void Start()
    {
        ranCombi = Random.Range(0, 3);
        M_material = gameObject.GetComponent<Renderer>().material;
        M_material.mainTexture = texCombi[ranCombi];

        if(ranCombi == 0)
        {
            Tex1 = 0;
            Tex2 = 8;
            Tex3 = 11;
            Tex4 = 6;
            Tex5 = 9;
        }
        if(ranCombi == 1)
        {
            Tex1 = 5;
            Tex2 = 10;
            Tex3 = 4;
            Tex4 = 2;
            Tex5 = 3;
        }
        if(ranCombi == 2)
        {
            Tex1 = 11;
            Tex2 = 6;
            Tex3 = 9;
            Tex4 = 0;
            Tex5 = 5;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
