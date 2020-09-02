using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{ 
    public Color firstColor;
    public Color secondColor;
    public GameObject Player;
    public GameObject Circle;
    bool mouseOverCircle = false;
    // Start is called before the first frame update
    private void OnMouseEnter()
    {
        mouseOverCircle = true;
        GetComponent<SpriteRenderer>().material.SetColor("_Color", secondColor);
    }

    private void Update()
    {
        if (mouseOverCircle == true && Input.GetMouseButtonDown(0))
        {
            Player.transform.position = Circle.transform.position;
           
        }
    }
    private void OnMouseExit()
    {
        mouseOverCircle = false;
        GetComponent<SpriteRenderer>().material.SetColor("_Color", firstColor);
    }

}
