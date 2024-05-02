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
    private bool isJumping = false;

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

    void Update()
    {
        if(Input.GetKey("up")) 
        {
            _rigidbody.AddForce(transform.forward * 70.0f, ForceMode.Force);
        }
        if(Input.GetKey("down")) 
        {
            _rigidbody.AddForce(transform.forward * -70.0f, ForceMode.Force);
        }
        if(Input.GetKey("right")) 
        {
            transform.Rotate(0f, 3.0f, 0f);
        }
        if(Input.GetKey("left")) 
        {
            transform.Rotate(0f, -3.0f, 0f);
        }

        //ジャンプ処理
        // if(Input.GetKey("space")&& !isJumping) 
        // {
        //     _rigidbody.AddForce(transform.up * 100.0f, ForceMode.Impulse);
        //     isJumping = true;
        // }

        // void OnCollisionEnter(Collision collision)
        // {
        //     if(collision.gameObject.CompareTag("Floor"))
        //     {
        //         isJumping = false;
        //     }
        // }

        if (_rigidbody.velocity.magnitude > 0.1f) {
            _animator.SetBool("walking", true);
        } else {
            _animator.SetBool("walking", false);
        }

        //_rigidbody.velocity = _velocity * _speed;
    }
}