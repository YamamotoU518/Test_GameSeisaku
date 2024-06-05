using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] GameObject _goal;
    [SerializeField] Transform[] _place;
    [SerializeField] int _CurrentPosition;
    bool _isStop = false;
    float _speed = 0.01f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        _CurrentPosition = 1;
    }

    void Update()
    {
        //int x = (int)Input.GetAxisRaw("Horizontal");
        //transform.Translate(Vector3.right * x * _speed);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (_CurrentPosition > 0)
                _CurrentPosition--;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (_CurrentPosition < 2)
                _CurrentPosition++;
        }
        Vector3 _pos = transform.position;
        _pos.x = _place[_CurrentPosition].transform.position.x;
        transform.position = _pos;


        if (!_isStop)
            _rigidbody.AddForce(0f, 0f, 1f);
        else
            _rigidbody.velocity = Vector3.zero;

        if (this.gameObject.transform.position.z >= _goal.gameObject.transform.position.z)
        {
            _isStop = true;
        }
    }
}
