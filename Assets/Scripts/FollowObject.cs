using UnityEngine;
using TMPro;

public class FollowObject : MonoBehaviour
{
    public Transform target;
    private Transform textMesh;

    void Start()
    {
        textMesh = GameObject.FindGameObjectWithTag("QuickText").transform;
    }

    void Update()
    {
        textMesh.transform.position = target.position;
    }
}
