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
    // Start is called before the first frame update
    void Start()
    {
        listPostion = 0;
        hasStarted = false;
        agent = GetComponent<NavMeshAgent>();
    }

    public void RunPatrol()
    {
        Transform target;
        if (listPostion == 0 && !hasStarted)
        {
            hasStarted = true;
            target = patrolList[listPostion];
            NavMesh.CalculatePath(transform.position, target.position, NavMesh.AllAreas, path);
            agent.SetPath(path);
        }



        float distance = agent.remainingDistance;

        if (distance < 0.5f)
        {
            listPostion++;
            if (listPostion >= patrolList.Count)
            {
                listPostion = 0;
            }

            target = patrolList[listPostion];
            NavMesh.CalculatePath(transform.position, target.position, NavMesh.AllAreas, path);
            agent.SetPath(path);
        }
    }
}
