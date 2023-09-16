using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControllerSide1 : MonoBehaviour
{
    private MeshRenderer mesh;
    private Material mat;
    private Vector2 matOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
        matOffset = mat.mainTextureOffset;
    }

    // Update is called once per frame
    void Update()
    {
        matOffset.x -= Time.deltaTime/10f;
        mat.mainTextureOffset = matOffset;
    }
}
