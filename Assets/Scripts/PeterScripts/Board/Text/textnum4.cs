using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textnum4 : MonoBehaviour
{
    public Playertilemover player;
    public int num;
    public Text showid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showid.text = num.ToString();

        if (player.move <= 17)
        {
            num = 17 - player.move;
        }
    }
}
