using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRayCast : MonoBehaviour
{
    [SerializeField] private float maxDistance = 10f;
    [SerializeField] private float maxRadius = 1f;
    [SerializeField] private Material greenMaterial;

    private void Start()
    {
        
        Ray ray = new Ray (transform.position, Vector3.forward);
        RaycastHit hit;
        if (Physics.SphereCast(ray,maxRadius, maxDistance))
        {
            //hit.transform.position +=new Vector3 (0,2,0);
            //hit.transform.gameObject.GetComponent<Renderer>().material = greenMaterial;
            Debug.Log("Object Detected");
        }
        else
        {
            Debug.Log("Nichego");
        }
        Debug.DrawRay(transform.position, Vector3.forward * maxDistance, Color.red, 10000);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z + maxDistance));
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(new Vector3(transform.position.x,transform.position.y, transform.position.z + maxDistance), maxRadius);
    }
}
