using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotote : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles=new Vector3(Time.time*500,0,0);
    }
}
