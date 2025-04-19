using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightray : MonoBehaviour
{
    public float speed = 2f;
    void Update()
    {
        Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 100f);

        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Player"))
            {
                hit.collider.GetComponent<ThirdPersonController>().MoveSpeed = speed * 0.1f; ;
            }

        }

    }
}
