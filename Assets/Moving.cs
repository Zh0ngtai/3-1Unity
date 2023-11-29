using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // 이동 속도를 조절하는 변수

    void Update()
    {
        // WASD 키 입력 감지
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 이동 방향 설정
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        // 이동의 부드러움을 주는 코드
        transform.Translate(movement * speed * Time.deltaTime);
    }
}