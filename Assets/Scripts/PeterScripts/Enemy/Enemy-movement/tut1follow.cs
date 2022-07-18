using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tut1follow : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveposs = player.transform.position.x;
        transform.position = new Vector3(moveposs, transform.position.y, transform.position.z);



    }
}
