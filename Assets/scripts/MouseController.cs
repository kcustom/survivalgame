using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    float xRotat;
    float yRotat;
    float xRotatCurrent;
    float yRotatCurrent;
    public Camera player;
    public GameObject playerGameObject;
    public float sense = 5f;
    public float smoothTime = 0.1f;
    float xCurrentVelosity;
    float yCurrentVelosity;
    

    private void Update()
    {
        MouseMove();
    }
    public void MouseMove()
    {
        xRotat += Input.GetAxis("Mouse X") * sense; //������� ����� �� x 
        yRotat += Input.GetAxis("Mouse Y") * sense; //������� ����� �� y
        yRotat = Mathf.Clamp(yRotat, -90, 90); // ����������� ���� ������

        xRotatCurrent = Mathf.SmoothDamp(xRotatCurrent, xRotat, ref xCurrentVelosity, smoothTime); // ����� ������� ������
        yRotatCurrent = Mathf.SmoothDamp(yRotatCurrent, yRotat, ref yCurrentVelosity, smoothTime);

        player.transform.rotation = Quaternion.Euler(-yRotatCurrent, xRotatCurrent, 0f); // ���������� ��������� transform, ����� rotation, Euler=�������� � ���� ����������.
        playerGameObject.transform.rotation = Quaternion.Euler(0f, xRotatCurrent, 0f);
    }
}
