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
    private bool isJumping = false; // ジャンプ中かどうか
    float walkingSpeed = 70.0f; //歩く速度
    float runningSpeed = 100.0f; //走る速度
    float rotationSpeed = 3.0f; //視点の回転速度
    float normalJump = 4.0f; // 通常ジャンプの大きさ
    float gravity = 10f; // 重力の大きさ

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
        //移動速度の設定、走るモーションの設定
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
        
        //歩くモーションの設定
        if (_rigidbody.velocity.magnitude > 0.1f) {
            _animator.SetBool("walking", true);
        } else {
            _animator.SetBool("walking", false);
        }

        //移動処理
        if(Input.GetKey("up")) 
        {
            _rigidbody.AddForce(transform.forward * speed, ForceMode.Force);
        }
        if(Input.GetKey("down")) 
        {
            _rigidbody.AddForce(transform.forward * -7 / 10 * speed, ForceMode.Force); //後ろに下がる速度は前進速度の7割
        }
        if(Input.GetKey("right")) 
        {
            transform.Rotate(0f, rotationSpeed, 0f);
        }
        if(Input.GetKey("left")) 
        {
            transform.Rotate(0f, -1 * rotationSpeed, 0f);
        }

        //ジャンプ処理
        if(Input.GetKey("space")&& !isJumping) 
        {
            _rigidbody.AddForce(transform.up * normalJump, ForceMode.Impulse);
        }
        Debug.Log(isJumping);
    }

    private void OnCollisionStay(Collision collision) {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
        // else {
        //     //_rigidbody.AddForce(transform.up * -1 * gravity, ForceMode.Force);
        // }
    }
    private void OnCollisionExit(Collision collision) {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}