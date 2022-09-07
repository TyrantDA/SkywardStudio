using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class patrol : MonoBehaviour
{
    public List<Transform> patrolList = new List<Transform>();
    public int listPostion;
    bool hasStarted;
    NavMeshAgent agent;
    NavMeshPath path;
    bool pathMade;
    [SerializeField] float distance;
    // Start is called before the first frame update
    void Start()
    {
        listPostion = 0;
        hasStarted = false;
        agent = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
        
    }

    void createPath()
    {
        NavMesh.CalculatePath(transform.position, patrolList[listPostion].position, NavMesh.AllAreas, path);
        agent.SetPath(path);
        pathMade = true;
        Debug.Log("Path Updated");
    }



    public void RunPatrol()
    {
        if(!pathMade)
        {
            createPath();
        }

        distance = agent.remainingDistance;
        if (distance < 0.2f)
        {
            listPostion++;
            pathMade = false;
            Debug.Log("next point");

            if(listPostion >= patrolList.Count)
            {
                listPostion = 0;
            }
        }
    }
}
