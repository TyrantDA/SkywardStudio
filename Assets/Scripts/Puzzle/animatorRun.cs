using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorRun : MonoBehaviour
{
    [SerializeField] List<Animator> AnimationList = new List<Animator>();
    [SerializeField] List<controlPanel> switchList = new List<controlPanel>();
    public string setName;
    bool running;
    // Start is called before the first frame update
    void Start()
    {
        running = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!running)
        {
            int hold = 0;
            for(int x = 0; x < switchList.Count; x++)
            {
                if(switchList[x].getActivated())
                {
                    hold++;
                }
            }

            if(hold == switchList.Count)
            {
                running = true;
                for(int x = 0; x < AnimationList.Count; x++)
                {
                    AnimationList[x].SetTrigger(setName);
                }
            }
        }
    }
}
