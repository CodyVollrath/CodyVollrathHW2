using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwatchObject : MonoBehaviour
{
    public GameObject colorObjects;
    public GameObject otherSwatch1;
    public GameObject otherSwatch2;
    public void OnMouseDown()
    {
        float scaler = 0.4f;
        var renderer = GetComponent<Renderer>();
        var thisColor = renderer.material.color;
        var mainColorObj = colorObjects.GetComponent<Renderer>();
        if (!thisColor.Equals(mainColorObj.material.color))
        {
            transform.localScale = new Vector3(transform.localScale.x + scaler, transform.localScale.y + scaler, transform.localScale.z + scaler);
            mainColorObj.material.color = renderer.material.color;
            foreach (Transform gameObj in colorObjects.transform)
            {
                var colorObj = gameObj.GetComponent<Renderer>();
                colorObj.material.color = renderer.material.color;
            }
        }
        if (otherSwatch1.transform.localScale.x > 1)
        {
            otherSwatch1.transform.localScale = new Vector3(transform.localScale.x - scaler, transform.localScale.y - scaler, transform.localScale.z - scaler);
        }
        if (otherSwatch2.transform.localScale.x > 1)
        {
            otherSwatch2.transform.localScale = new Vector3(transform.localScale.x - scaler, transform.localScale.y - scaler, transform.localScale.z - scaler);
        }

    }
}
