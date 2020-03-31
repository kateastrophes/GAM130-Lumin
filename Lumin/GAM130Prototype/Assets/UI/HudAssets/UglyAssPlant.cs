using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UglyAssPlant : MonoBehaviour
{
    public OxygenBarScript OxygenScript;  


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OxygenScript.plantsCount+=1;
            OxygenScript.checkedIfDecreasing();
        }        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OxygenScript.plantsCount-= 1;
            OxygenScript.checkedIfDecreasing();
        }
    }

    public void Update()
    {
        
            
    }


}
