using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float runSpeed;
    public float currentSpeed;
    public float jumpForce;
    float xMove; // ���������� �������� ������/�����
    float zMove; // �������� �����/������



    CharacterController player;
    Vector3 moveDirection;
    void Start()
    {
        player = GetComponent<CharacterController>(); // ������� � player ��������� charactercontroller
        
    }

    void Update()
    {
        Move(); // ��������� ����� ����� �� ���������� ������ ����
        
    }

    void Move()
    {
        xMove = Input.GetAxis("Horizontal"); // �������� �� �����������
        zMove = Input.GetAxis("Vertical"); // �� ���������
        if (player.isGrounded)
        {
            moveDirection = new Vector3(xMove, 0f, zMove);
            moveDirection = transform.TransformDirection(moveDirection);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y += jumpForce;
            }
        }
        moveDirection.y -= 0.1f;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = runSpeed;
        }
        else
        {
            currentSpeed = moveSpeed;
        }

        player.Move(moveDirection * Time.deltaTime * currentSpeed);



    }
}
