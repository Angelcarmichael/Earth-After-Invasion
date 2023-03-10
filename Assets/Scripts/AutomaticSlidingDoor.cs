using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticSlidingDoor : MonoBehaviour
{
    public float doorSpeed = 1.0f;

    public bool isOpen = false;
    public bool isDone = true;

    private Vector3 initialPosition;
    public Vector3 targetPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isOpen && other.CompareTag("Player") && isDone == true)
        {
            isDone = false;
            StartCoroutine(OpenDoor());
        }
    }

    /*private void OnTriggerExit(Collider other)
    {
        if (isOpen && other.CompareTag("Player") && isDone == true)
        {
            isDone = false;
            StartCoroutine(CloseDoor());
        }
    }*/

    private IEnumerator OpenDoor()
    {
        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, doorSpeed * Time.deltaTime);
            yield return null;
        }
        isOpen = true;

        StartCoroutine(CloseDoor());
    }

    private IEnumerator CloseDoor()
    {
        while (Vector3.Distance(transform.position, initialPosition) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, initialPosition, doorSpeed * Time.deltaTime);
            yield return null;
        }
        isOpen = false;
        isDone = true;
    }
}
