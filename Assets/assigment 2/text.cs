using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text : MonoBehaviour

{//creating the couting int to create the promesh 
    int count = 0;
    public TextMeshProUGUI counter;
    // Start is called before the first frame update
    void Start()
    {
        // making it so that the timmerw ill not start out as blanc text 
        counter.text = "times clicked " + count;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void counting() 
    {//creating void function so that when buttons clicked the counter goes up 
        count += 1;
        counter.text ="times clicked " + count;
       
    }
}
