using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class mousehover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }

    private void OnMouseEnter()
    {
        GetComponent<TextMeshPro>().color = Color.green;
    }

    void OnMouseExit()
    {
        GetComponent<TextMeshPro>().color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
