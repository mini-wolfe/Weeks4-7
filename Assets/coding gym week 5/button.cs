using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
    
{
    SpriteRenderer spriterenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown() 
        { 
            spriterenderer.color = new Color(1,0.5f,0.3f,0.5f);
        }
    }
}
