using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManage : MonoBehaviour
{
    public AudioSource source;
    public AudioClip doorslam;

    public GameObject monsterWalk;
    public GameObject monsterRun;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setActiveWalk()
    {
        monsterWalk.SetActive(true);
    }

    public void setActiveRun()
    {
        source.PlayOneShot(doorslam);
        monsterRun.SetActive(true);
    }

    public void DisableScript()
    {
        Destroy(this);
    }
}
