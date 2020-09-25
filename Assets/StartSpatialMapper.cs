using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpatialMapper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    float timeBeforeStart = 5f;
    void Update(){
        if(timeBeforeStart > 0){
            timeBeforeStart -= Time.deltaTime;
            if(timeBeforeStart < 0){
                GetComponent<ZEDManager>().StartSpatialMapping();        
            }
        }

    }
}
