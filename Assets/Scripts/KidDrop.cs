using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidDrop : MonoBehaviour
{
    public GameObject apple;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Vendor").tag = "Angry";
        apple.SetActive(true);
    }

}
