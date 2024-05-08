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
    private float jumpStartTime = 0; // ジャンプ開始時間
    private float jumpCoolTime = 0.65f; // ジャンプクールタイム
    private float chergeJumpCoolTime = 0.3f; // ジャンプを溜めなおすまでのクールタイム
    float walkingSpeed = 70.0f; //歩く速度
    float runningSpeed = 100.0f; //走る速度
    float rotationSpeed = 3.0f; //視点の回転速度
    static float normalJump = 8.3f; // 通常ジャンプの大きさ
    static float maxJump = 12.0f; // ためジャンプの最大の大きさ
    float jumpPower = normalJump; // ジャンプの大きさ

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

        //ジャンプの溜め処理
        if(Input.GetKey("space") && !isJumping && Time.time - jumpStartTime > chergeJumpCoolTime) 
        {
            jumpPower += 0.1f;
            if(jumpPower > maxJump) 
            {
                jumpPower = maxJump;
            }
        }
        //ジャンプ処理
        if(Input.GetKeyUp("space") && !isJumping && Time.time - jumpStartTime > jumpCoolTime) 
        {
            _rigidbody.AddForce(transform.up * jumpPower, ForceMode.Impulse);
            jumpStartTime = Time.time;
            jumpPower = normalJump;
        }
    }

    //地面についているか判定
    private void OnCollisionStay(Collision collision) {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
    //地面から離れたか判定
    private void OnCollisionExit(Collision collision) {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
            jumpStartTime = Time.time;
        }
    }
}