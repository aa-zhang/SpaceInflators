using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    private float _userHorizontalInput;
    private float _userVerticalInput;
    private float _speedMultipler = 0.1f;

    private Rigidbody _rigidbody;
    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _userHorizontalInput = Input.GetAxis("Horizontal");
        _userVerticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        // Debug.Log(_userHorizontalInput);
        _rigidbody.velocity += _transform.up * _userVerticalInput * _speedMultipler;
        _rigidbody.velocity += _transform.right * _userHorizontalInput * _speedMultipler;
    }

    public void ChangeSpeedByFactor(int factor)
    {
        _speedMultipler = _speedMultipler * factor;
    }
}
