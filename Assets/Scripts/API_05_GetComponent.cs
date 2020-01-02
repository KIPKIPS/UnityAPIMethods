using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_05_GetComponent : MonoBehaviour {
    public GameObject target;
    // Start is called before the first frame update
    void Start() {
        Receiver receiver = target.GetComponent<Receiver>();
        Transform t = target.GetComponent<Transform>();
        Debug.Log(receiver);
        Debug.Log(t);
        Debug.Log("---------------------------------");

        Receiver[] receivers = target.GetComponents<Receiver>();
        Debug.Log(receivers.Length);
        Debug.Log("---------------------------------");

        receivers = target.GetComponentsInChildren<Receiver>();
        foreach (Receiver c in receivers) {
            Debug.Log(receiver);
        }
        Debug.Log("---------------------------------");
        receivers = target.GetComponentsInParent<Receiver>();
        foreach (Receiver c in receivers) {
            Debug.Log(receiver);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
