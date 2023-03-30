using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiAnimal : MonoBehaviour
{
    public float moveSpeed = 3.0f; // Speed of the animal's movement
    public float rotationSpeed = 3.0f; // Speed of the animal's rotation
    public float wanderRadius = 10.0f; // Radius within which the animal can wander
    public float wanderTimer = 5.0f; // Time between each wander

    private Transform target; // The animal's current target (where it's headed)
    private float timer; // Countdown timer for wandering

    // Start is called before the first frame update
    void Start()
    {
        timer = wanderTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // If the timer has reached the wander time, pick a new target and reset the timer
        if (timer >= wanderTimer)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            target.position = newPos;
            timer = 0;
        }

        // Rotate towards the target
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), rotationSpeed * Time.deltaTime);

        // Move towards the target
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    // Generate a random position within the wander radius
    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;
        randDirection += origin;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);
        return navHit.position;
    }
}
