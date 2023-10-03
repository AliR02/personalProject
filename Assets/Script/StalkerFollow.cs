using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class StalkerFollow : MonoBehaviour
{
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent stalker = GetComponent<UnityEngine.AI.NavMeshAgent>();
        stalker.SetDestination(Player.position);
    }
}
