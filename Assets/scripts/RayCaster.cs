using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    private float maxDist = 5f;
    [SerializeField] private LayerMask layerMask;

    private void Start()
    {
        Ray ray = new Ray(transform.position, Vector3.forward);
        if (Physics.Raycast(ray, maxDist, layerMask))
        {
            Debug.Log("hit");
        }
        Debug.DrawRay(transform.position, Vector3.forward * maxDist, Color.red, 10000);
    }

}
