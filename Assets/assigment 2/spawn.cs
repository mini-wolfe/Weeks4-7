using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEditor;

public class spawn : MonoBehaviour
{
  
    //creating a call to the prefab
    public GameObject interactionA;
    public GameObject interactionB;
    public GameObject interactionC;
   
    //creating a new vector 3 
    Vector3 positionA = new Vector3(0,1,0);
    Vector3 positionB = new Vector3(0,3, 0);
    Vector3 positionC = new Vector3(1, 0, 0);




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void buttonPressedA()
    {
        //this code spawn the first item for the tomagachi to interact with. it is  set to the screen size of  a place holder,negating rotation with quaternion identity
        Instantiate(interactionA,positionA,Quaternion.identity);
        //destroy the prephab after 3 seconds
        Destroy(interactionA,3);
       
        
       
    }
    public void ButtonPressedB()
    {
        //this code spawn the first item for the tomagachi to interact with. it is  set to the screen size of  a place holder,negating rotation with quaternion identity
        Instantiate(interactionB, positionB, Quaternion.identity);
        //destroy the prephab after 3 seconds
       Destroy(interactionB, 3);

    }
    public void ButtonaPressedC()
    {
        //this code spawn the first item for the tomagachi to interact with. it is  set to the screen size of  a place holder,negating rotation with quaternion identity
        Instantiate(interactionC, positionC, Quaternion.identity);
        //destroy the prephab after 3 seconds
        Destroy(interactionC, 3);
    }
}
