using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_01_EventFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    void Awake() {
        //Debug.Log("Awake");
    }

    void OnEnable() {
        Debug.Log("OnEnable");
    }

    void FixedUpdate() {
        Debug.Log("FixedUpdate");
    }

    void LateUpdate() {
        Debug.Log("LateUpdate");
    }

//    void OnDrawGizmos() {
//        Debug.Log("OnDrawGizmos");
//    }

    void OnDisable() {
        Debug.Log("OnDisable");
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    void Reset() {
        Debug.Log("Reset");
    }
}
