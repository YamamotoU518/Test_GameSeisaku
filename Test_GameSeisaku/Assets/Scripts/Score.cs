using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text _score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _score.text = GameManager.Instance._score.ToString();
    }
}
