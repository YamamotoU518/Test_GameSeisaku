using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] GameObject _goal;
    bool _isStop = false;
    float _speed = 0.01f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {

    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * x * _speed);

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
