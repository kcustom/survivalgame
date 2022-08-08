using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aiCharContlr : MonoBehaviour
{

    private NavMeshAgent agent;
    [SerializeField] private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
