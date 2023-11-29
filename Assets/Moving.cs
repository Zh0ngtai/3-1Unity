using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // �̵� �ӵ��� �����ϴ� ����

    void Update()
    {
        // WASD Ű �Է� ����
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // �̵� ���� ����
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        // �̵��� �ε巯���� �ִ� �ڵ�
        transform.Translate(movement * speed * Time.deltaTime);
    }
}