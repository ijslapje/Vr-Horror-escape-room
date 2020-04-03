using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public string newscene;
    private void FixedUpdate()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            SceneManager.LoadScene(newscene);
            Debug.Log("Press Y");
        }
    }
}
