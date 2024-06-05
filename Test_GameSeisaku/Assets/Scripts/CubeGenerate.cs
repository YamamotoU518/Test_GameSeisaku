using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerate : MonoBehaviour
{
    [SerializeField] GameObject _obj;
    [SerializeField] GameObject _startObj;
    [SerializeField] GameObject _goalObj;
    float _start;
    float _goal;

    void Start()
    {
        _start = _startObj.transform.position.z + 5;
        _goal = _goalObj.transform.position.z;
        for (float i = _start; i < _goal; i += 5)
        {
            Instantiate(_obj, new Vector3(0, 1, i), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
