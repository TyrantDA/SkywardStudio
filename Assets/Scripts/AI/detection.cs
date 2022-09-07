using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class detection : MonoBehaviour
{
    public float radius;
    NavMeshAgent agent;
    bool seen;
    patrol pat;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        pat = GetComponent<patrol>();
        seen = false;
    }

    // Update is called once per frame
    void Update()
    {
        seen = false;
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider hitCollider in hitColliders)
        {
            if(hitCollider.CompareTag("Player"))
            {
                agent.destination = hitCollider.gameObject.transform.position;
                seen = true;
            }
        }

        if (!seen)
        {
            pat.RunPatrol();
        }
    }
}
