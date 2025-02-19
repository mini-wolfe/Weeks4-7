using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    //creating a referance to a sprite 
    public SpriteRenderer sr;
    //array list holding  all the diffrent tomagachi skins
    public Sprite[] skins;
    //
    public Slider moving;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //creating a function that changes the skin of the tomagachi when  the slider is pushed 
    public void colourShift()
    {
        int sValue = Mathf.RoundToInt(moving.value);
        sr.sprite = skins[sValue];
    }
}