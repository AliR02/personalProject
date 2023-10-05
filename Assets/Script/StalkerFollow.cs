using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class StalkerFollow : MonoBehaviour
{
    public Transform Player;
    public float maxDistance = 10f; // Maximum distance for full audio volume

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent stalker = GetComponent<UnityEngine.AI.NavMeshAgent>();
        stalker.SetDestination(Player.position);
        // Calculate the distance between the enemy and the player/listener
        float distance = Vector3.Distance(transform.position, Player.position);

        // Map the distance to the volume range
        float volume = Mathf.Clamp01(1f - (distance / maxDistance));

        // Set the audio volume
        audioSource.volume = volume;
    }
}
