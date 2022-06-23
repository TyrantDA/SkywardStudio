using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<Transform> pointlist = new List<Transform>();
    public float radius;
    public int postionInList;
    [SerializeField] float distance;
    Vector3 centre;
    NavMeshAgent agent;
    private NavMeshPath path;
    bool pathMade;
    bool seen;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        seen = false;
        pathMade = false;
        path = new NavMeshPath();
    }

    void createPath()
    {
        NavMesh.CalculatePath(transform.position, pointlist[postionInList].position, NavMesh.AllAreas, path);
        agent.SetPath(path);
        pathMade = true;
        Debug.Log("Path Updated");
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] seePlayer = Physics.OverlapSphere(transform.position, 60);

        if (!seen || postionInList >= pointlist.Count)
        {
            for (int x = 0; x < seePlayer.Length; x++)
            {
                if (seePlayer[x].gameObject.transform.CompareTag("Player"))
                {
                    transform.LookAt(seePlayer[x].transform);

                }
            }
        }



        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);

        for(int x = 0; x < hitColliders.Length; x++)
        {
            seen = false;
            if(hitColliders[x].gameObject.transform.CompareTag("Player"))
            {
                seen = true;
                agent.speed = 3.5f;
                break;
                
            }
        }
        Debug.Log(seen);
        if (seen && postionInList < pointlist.Count)
        {
            if(!pathMade)
            {
                createPath();
            }
            else
            {
                distance = agent.remainingDistance;
                if (distance < 0.2f)
                {
                    postionInList++;
                    pathMade = false;
                    Debug.Log("next point");
                }
            }
        }
        else
        {
            agent.speed = 0;
        }

        

    }
}
