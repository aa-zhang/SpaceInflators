using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        Debug.Log(other.tag);
        if (other.tag == "Player")
        {
            GameManager.manager.TriggerGameOver();
            print("hi");
        }
    }
}
