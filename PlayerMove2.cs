using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor;
using UnityEngine;
//using UnityEngine.InputSystem;


public class PlayerMove2 : MonoBehaviour
{
    private float _speed = 5f;
    private float _jump = 4f;
    public Rigidbody2D _rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        // _startedPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            _rb.linearVelocity = new Vector2(_speed, _rb.linearVelocityY);
        else if (Input.GetKey(KeyCode.A))
            _rb.linearVelocity = new Vector2(-_speed, _rb.linearVelocityY);
        
    }
}