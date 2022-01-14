using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _playerInput;
    private CharacterController _characterController;

    private int _isWalkingHash;
    private int _isAttackingHash;
    private int _isShieldingHash;

    private Vector2 _currentMoveInput;
    private Vector3 _currentMove;
    private bool _isMovePressed;
    private bool _isAttackPressed;
    private bool _isShieldPressed;
    
    [SerializeField] private Animator _animator;
    [SerializeField] private float rotationFactorPerformance = 1f;
    [SerializeField] private float _speed = 4f;
    
    private void Awake()
    {
        //initially set reference variable
        _playerInput = new PlayerInput();
        _characterController = GetComponent<CharacterController>();

        _isWalkingHash = Animator.StringToHash("isWalking");
        _isAttackingHash = Animator.StringToHash("isAttacking");
        _isShieldingHash = Animator.StringToHash("isShielding");
        
        //set player input callbacks
        _playerInput.Zelda1Controls.Move.started += OnMovementInput;
        _playerInput.Zelda1Controls.Move.canceled += OnMovementInput;
        _playerInput.Zelda1Controls.Move.performed += OnMovementInput;
        
        _playerInput.Zelda1Controls.Attack.started += OnAttack;
        _playerInput.Zelda1Controls.Attack.canceled += OnAttack;
        _playerInput.Zelda1Controls.Attack.performed += OnAttack;
        
        _playerInput.Zelda1Controls.Shield.started += OnShield;
        _playerInput.Zelda1Controls.Shield.canceled += OnShield;
        _playerInput.Zelda1Controls.Shield.performed += OnShield;
    }
    
    private void Update()
    {
        HandleGravity();
        HandleRotation();
        AnimationHandler();
        _characterController.Move(_currentMove * Time.deltaTime * _speed);
    }
    
    private void OnMovementInput(InputAction.CallbackContext context)
    {
        _currentMoveInput = context.ReadValue<Vector2>();
        _currentMove.x = _currentMoveInput.x;
        _currentMove.z = _currentMoveInput.y;

        _isMovePressed = _currentMoveInput.x != 0 || _currentMoveInput.y != 0;
        Debug.Log("walkies");
    }

    private void OnAttack(InputAction.CallbackContext context)
    {
        _isAttackPressed = context.ReadValueAsButton();
        Debug.Log("attacked");
    }
    
    private void OnShield(InputAction.CallbackContext context)
    {
        _isShieldPressed = context.ReadValueAsButton();
        Debug.Log("blocked");
    }
    
    private void HandleRotation()
    {
        Vector3 positionToLookAt;
        positionToLookAt.x = _currentMove.x;
        positionToLookAt.y = 0f;
        positionToLookAt.z = _currentMove.z;
        
        Quaternion currentRotation = transform.rotation;

        if (_isMovePressed) {
            Quaternion targetRotation = Quaternion.LookRotation(positionToLookAt);
            transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, rotationFactorPerformance);
        }
    }

    private void HandleGravity()
    {
        if (_characterController.isGrounded) {
            float groundGravity = -.05f;
            _currentMove.y = groundGravity;
        } else {
            float gravity = -9.81f;
            _currentMove.y = gravity;
        }
    }
    
    private void AnimationHandler()
    {
        bool isWalking = _animator.GetBool(_isWalkingHash);
        bool isAttacking = _animator.GetBool(_isAttackingHash);
        bool isShielding = _animator.GetBool(_isShieldingHash);

        if (_isMovePressed && !isWalking) {
            _animator.SetBool(_isWalkingHash, true);
        }
        else if (!_isMovePressed && isWalking) {
            _animator.SetBool(_isWalkingHash, false);
        }

        if (_isAttackPressed && !isAttacking) {
            _animator.SetBool(_isAttackingHash, true);
        }
        
        if (!_isAttackPressed && isAttacking) {
            _animator.SetBool(_isAttackingHash, false);
        }
        
        if (_isShieldPressed && !isShielding) {
            _animator.SetBool(_isShieldingHash, true);
        }
        
        if (!_isShieldPressed && isShielding) {
            _animator.SetBool(_isShieldingHash, false);
        }
    }
    
    private void OnEnable()
    {
        _playerInput.Zelda1Controls.Enable();
    }
    
    private void OnDisable()
    {
        _playerInput.Zelda1Controls.Disable();
    }
}
