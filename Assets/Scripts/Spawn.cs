using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject placeholder;
    public GameObject enemy;
    public controlPanel Gen;
    bool done;
  

    // Update is called once per frame
    void Update()
    {
        if(Gen.getActivated() && !done)
        {
            placeholder.SetActive(false);
            enemy.SetActive(true);
            done = true;
        }
    }
}
