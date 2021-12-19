using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputParse : MonoBehaviour
{
    private PlayerInput _playerInput;
    //private PlayerInput.NameOFActionMap _playerControlsActions;
    private PlayerInput.Zelda1ControlsActions _playerControlsActions;

    [SerializeField] private CharacterControllerMove _charConMove;


    private void Awake()
    {
        _playerInput = new PlayerInput();
        _playerControlsActions = _playerInput.Zelda1Controls;

        //_playerControlsActions.InputName.performed += Script.Function;
        _playerControlsActions.FeatherJump.performed += _charConMove.Jump; 
        _playerControlsActions.Attack.performed += _charConMove.Attack;
        _playerControlsActions.Shield.performed += _charConMove.Shield;
        
        _playerControlsActions.Enable();
    }

    private void FixedUpdate()
    {
        _charConMove.MovePlayer(_playerControlsActions.Move.ReadValue<Vector2>());
    }
}