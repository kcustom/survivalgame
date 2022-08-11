using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private float maxDistance = 10f;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private GameObject firstGun;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(new Vector3(cam.pixelWidth * 0.5f, cam.pixelHeight * 0.5f, 0));
            if (Physics.Raycast(ray,out hit, layerMask))
            {
                hit.transform.gameObject.GetComponent<Rigidbody>().useGravity = true; 
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            firstGun.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
        }


    }
}
