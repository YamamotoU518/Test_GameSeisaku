using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] GameObject _goal;
    bool _isStop = false;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {

    }

    void Update()
    {
        if (!_isStop)
            _rigidbody.AddForce(0f, 0f, -1f);
        else
            _rigidbody.velocity = Vector3.zero;

        if (this.gameObject.transform.position.z <= _goal.gameObject.transform.position.z)
        {
            _isStop = true;
        }
    }
}
