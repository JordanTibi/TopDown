using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputSettings;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] InputActionReference _moveInput;

    [SerializeField] Rigidbody2D rb;
    [SerializeField] float _speed;
    [SerializeField] float _movingTreshold;
    [SerializeField] Animator _animator;

    private void Start()
    {
        _moveInput.action.started += StartMove; ;
        _moveInput.action.performed += UpdateMove; ;
        _moveInput.action.canceled += EndMove; ;

        

    }

    private void EndMove(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void UpdateMove(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void StartMove(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }
}
