using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInflation : MonoBehaviour
{
    private Transform _transform;

    private float _inflationFactor = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void inflateShip()
    {
        _transform.localScale += new Vector3(_inflationFactor, _inflationFactor, _inflationFactor);
    }
}
