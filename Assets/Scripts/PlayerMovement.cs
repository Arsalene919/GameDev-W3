using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _horizontalInput;
    [SerializeField] private float _verticalInput;
    [SerializeField] private float _speed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(_horizontalInput, 0, 0) * _speed * Time.deltaTime);
        _verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, _verticalInput, 0) * _speed * Time.deltaTime);
    }

    
}
