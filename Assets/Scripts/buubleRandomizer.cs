using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buubleRandomizer : MonoBehaviour
{
    [SerializeField] List<Animator> AnimationList = new List<Animator>();
    public string setName;
    public float bubblePerSecond;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("bubble");
    }

    IEnumerator bubble()
    {
        while (true)
        {
            List<int> hasRunning = new List<int>();
            bool alreadyRunning = false;
            float hold = Random.Range(0, bubblePerSecond);
            Debug.Log(bubblePerSecond);
            for (int x = 0; x < bubblePerSecond; x++)
            {
                int runSelect = Random.Range(0, (AnimationList.Count));
                for (int y = 0; y < hasRunning.Count; y++)
                {
                    if (hasRunning[y] == runSelect)
                    {
                        alreadyRunning = true;
                    }
                }
                if (!alreadyRunning)
                {
                    hasRunning.Add(runSelect);
                    AnimationList[runSelect].SetTrigger(setName);
                }

                Debug.Log("bubble " + runSelect);
                alreadyRunning = false;
            }
            Debug.Log("Run");
            yield return new WaitForSeconds(3f);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
