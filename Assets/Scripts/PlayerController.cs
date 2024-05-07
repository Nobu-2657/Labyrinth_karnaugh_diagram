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
    private Vector3 _aim; 
    private Quaternion _playerRotation; 
    float walkingSpeed = 70.0f;
    float runningSpeed = 100.0f;
    float rotationSpeed = 3.0f;

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
        //移動速度の設定
        float speed = walkingSpeed;
        if (Input.GetKey("left shift")) {
            speed = runningSpeed;
            if (_rigidbody.velocity.magnitude > 0.1f){
                _animator.SetBool("running", true);
            }
            else {
                _animator.SetBool("running", false);
            }
        }
        else {
            _animator.SetBool("running", false);
        }

        if(Input.GetKey("up")) 
        {
            _rigidbody.AddForce(transform.forward * speed, ForceMode.Force);
        }
        if(Input.GetKey("down")) 
        {
            _rigidbody.AddForce(transform.forward * -7 / 10 * speed, ForceMode.Force); //後ろ向きの速度は前向きの7割
        }
        if(Input.GetKey("right")) 
        {
            transform.Rotate(0f, rotationSpeed, 0f);
        }
        if(Input.GetKey("left")) 
        {
            transform.Rotate(0f, -1 * rotationSpeed, 0f);
        }

        if (_rigidbody.velocity.magnitude > 0.1f) {
            _animator.SetBool("walking", true);
        } else {
            _animator.SetBool("walking", false);
        }
    }
}