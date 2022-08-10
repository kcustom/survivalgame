using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCaster : MonoBehaviour
{
    private float radius = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position, transform.localScale, Quaternion.identity);
        foreach (Collider collider in colliders)
        {
            Debug.Log(collider.gameObject.name);
        }

        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
