using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonHit : MonoBehaviour
{

    public ShipInflation shipInflation;
    // Start is called before the first frame update
    void Start()
    {
        shipInflation = FindObjectOfType<ShipInflation>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(this.gameObject);
            shipInflation.inflateShip();
        }
    }
}
