using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody _rigidbody;
    private Transform _transform;
    private Animator _animator;
    private float _horizontal;
    private float _vertical;
    private Vector3 _velocity;
    private float _speed = 2f;

    private Vector3 _aim; 
    private Quaternion _playerRotation; 

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
        _animator = GetComponent<Animator>();

        _playerRotation = _transform.rotation; 

        Application.targetFrameRate = 60;
    }

    void FixedUpdate()
    {
        if(Input.GetKey("up")) 
        {
            transform.position += transform.forward * 0.03f;
        }
        if(Input.GetKey("down")) 
        {
            transform.position -= transform.forward * 0.03f;
        }
        if(Input.GetKey("right")) 
        {
            transform.Rotate(0f, 3.0f, 0f);
        }
        if(Input.GetKey("left")) 
        {
            transform.Rotate(0f, -3.0f, 0f);
        }

        if (_velocity.magnitude > 0.1f) {
            _animator.SetBool("walking", true);
        } else {
            _animator.SetBool("walking", false);
        }

        _rigidbody.velocity = _velocity * _speed;
    }
}