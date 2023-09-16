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

    private float _leftBoundary = -6;
    private float _rightBoundary = 6;
    private float _topBoundary = 18;
    private float _bottomBoundary = 12;

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
        Debug.Log(_transform.position);
        if (_transform.position.x <= _leftBoundary)
        {
            _rigidbody.velocity = new Vector3(0, _rigidbody.velocity.y, _rigidbody.velocity.z);
            _userHorizontalInput = Mathf.Max(0, _userHorizontalInput);

        }
        if (_transform.position.x >= _rightBoundary)
        {
            _rigidbody.velocity = new Vector3(0, _rigidbody.velocity.y, _rigidbody.velocity.z);
            _userHorizontalInput = Mathf.Min(0, _userHorizontalInput);

        }
        if (_transform.position.y >= _topBoundary)
        {
            _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0, _rigidbody.velocity.z);
            _userHorizontalInput = Mathf.Max(0, _userVerticalInput);

        }
        if (_transform.position.y <= _bottomBoundary)
        {
            _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0, _rigidbody.velocity.z);
            _userHorizontalInput = Mathf.Min(0, _userVerticalInput);
        }

        _rigidbody.velocity += _transform.up * _userVerticalInput * _speedMultipler;
        _rigidbody.velocity += _transform.right * _userHorizontalInput * _speedMultipler;
    }

    public void ChangeSpeedByFactor(int factor)
    {
        _speedMultipler = _speedMultipler * factor;
    }
}