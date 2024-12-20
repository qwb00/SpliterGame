using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigButtonNotClose : MonoBehaviour
{
    public Door door;
    public PlayerController playerController;
    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BigPlayer") && playerController.isCombined)
        {
            door.OpenDoor();
            transform.localScale = new Vector3(originalScale.x, originalScale.y / 2, originalScale.z);
        }
    }
}
