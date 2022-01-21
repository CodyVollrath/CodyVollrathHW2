using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swatches : MonoBehaviour
{
    public GameObject swatchObjects;
    public GameObject regularObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            var rendered = swatchObjects.GetComponent<Renderer>();
            rendered.material.SetColor("_Color", Color.red);
        }
    }
}
