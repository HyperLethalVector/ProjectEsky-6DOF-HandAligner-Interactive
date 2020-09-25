using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowOther : MonoBehaviour
{
    public Transform other;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = other.transform.position;
        transform.rotation = other.transform.rotation;
    }
}
