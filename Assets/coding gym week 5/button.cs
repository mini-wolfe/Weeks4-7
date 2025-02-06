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
        if (Input.GetKeyDown(KeyCode.R)) 
        { 
            spriterenderer.color = Color.blue;
        }
    }
}
