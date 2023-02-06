using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithcHunt : MonoBehaviour
{

    public float timeInterval = 5.0f;

    void Start()
    {
        InvokeRepeating("PerformAction", 0, timeInterval);
    }

    void PerformAction()
    {
        Debug.Log("Hunt");
        // Acción que quieres que se realice cada "timeInterval" segundos.
        if (GameObject.Find("Calderus").tag == "Transformer")
        {
            //Debug.Log("test");
            GameObject.Find("Calderus").tag = "Hunted";
        }
        else if (GameObject.Find("Calderus").tag == "Hunted")
        {
            GameObject.Find("Calderus").tag = "Transformer";
        }
    }
    private void Update()
    {
        

    }
}
