using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    //creating a call to the prefab
    public GameObject interactionA;
    //creating a new vector 3 
    Vector3 position = new Vector3(0,1,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void buttonPressed()
    {
        //this code spawn the first item for the tomagachi to interact with. it is  set to the screen size of  a place holder,negating rotation with quaternion identity
        Instantiate(interactionA,position,Quaternion.identity);
        //destroy the prephab after 3 seconds
        Destroy(interactionA,3);
    }
}
