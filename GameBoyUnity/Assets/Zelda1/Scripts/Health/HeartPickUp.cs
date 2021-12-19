using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPickUp : MonoBehaviour
{   
    //playerFeedback
    [SerializeField] private float _rotationSpeed = 1f;
    [SerializeField] private float _pingPongSpeed = 0.5f;
    [SerializeField] private float _current, _target;
    [SerializeField] private Vector3 _floatTop;
    [SerializeField] private AnimationCurve _curve;

    //health
    [SerializeField] private float _hPPoints = .5f;
    [SerializeField] private HealthBar _healthBar;

    private void Update()
    {
        transform.Rotate(new Vector3(0, _rotationSpeed, 0) * Time.deltaTime);
        
        
        if (Input.GetKey(KeyCode.Alpha1)) _target = _target == 0 ? 1 : 0; // iets doen met de target dat ie alleen bij hele values switched, nu gittered hij
        Bounce();

    }

    private void Bounce()
    {
        _current = Mathf.MoveTowards(_current, _target, _pingPongSpeed * Time.deltaTime);
        transform.position = Vector3.Lerp(Vector3.zero, _floatTop, _curve.Evaluate(Mathf.PingPong(_current, 0.5f) * 2));
    }
    
    private void OnTriggerEnter(Collider other)
    {
        _healthBar.Health(_hPPoints);
        Destroy(gameObject);
    }
}
