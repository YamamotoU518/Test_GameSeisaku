using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerate : MonoBehaviour
{
    [SerializeField] GameObject _obj;
    [SerializeField] GameObject _startObj;
    [SerializeField] GameObject _goalObj;
    [SerializeField] Transform[] _place;
    float _start;
    float _goal;

    void Start()
    {
        _start = _startObj.transform.position.z + 5;
        _goal = _goalObj.transform.position.z;
        for (float i = _start; i < _goal; i += 5)
        {
            int _num = Random.Range(0, _place.Length);
            Instantiate(_obj, new Vector3(_place[_num].position.x, 1f, i), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
