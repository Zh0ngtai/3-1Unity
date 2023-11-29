using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;
    private Animator _animator;
    private void Awake()
    {
        _camera = Camera.main;
        _animator = GetComponent<Animator>();
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);

        // ������ ���ο� ���� �ִϸ��̼� �������� ����
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        Vector2 newAimDirection = (worldPos - (Vector2)transform.position).normalized;

        if (newAimDirection.magnitude >= .9f)
        {
            CallLookEvent(newAimDirection);
        }
    }

    public void OnFire(InputValue value)
    {
        Debug.Log("OnFire" + value.ToString());
    }

    // ������ ���ο� ���� �ִϸ��̼� �������� ����
    private void LateUpdate()
    {
        _animator.SetBool("IsMoving", false);
    }
}