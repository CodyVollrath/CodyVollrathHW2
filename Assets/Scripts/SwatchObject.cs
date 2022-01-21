using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwatchObject : MonoBehaviour
{
    public GameObject colorObjects;
    private bool toggle = true;
    public void OnMouseDown()
    {
        float scaler = 0.4f;
        var renderer = GetComponent<Renderer>();
        
        if (toggle)
        {
            transform.localScale = new Vector3(transform.localScale.x + scaler, transform.localScale.y + scaler, transform.localScale.z + scaler);
            var mainColorObj = colorObjects.GetComponent<Renderer>();
            mainColorObj.material.color = renderer.material.color;
            foreach (Transform gameObj in colorObjects.transform) 
            {
                var colorObj = gameObj.GetComponent<Renderer>();
                colorObj.material.color = renderer.material.color;
            }
            toggle = false;
        }
        else 
        {
            transform.localScale = new Vector3(transform.localScale.x - scaler, transform.localScale.y - scaler, transform.localScale.z - scaler);
            
            toggle = true;
        }

    }
}
