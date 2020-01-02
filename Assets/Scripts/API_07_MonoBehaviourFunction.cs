using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_07_MonoBehaviourFunction : MonoBehaviour
{
    public Receiver receiver;
    // Start is called before the first frame update
    void Start()
    {
        #region MyRegion
        Debug.Log(this.isActiveAndEnabled);
        Debug.Log(this.enabled);
        enabled = false;
        Debug.Log(name);
        Debug.Log(tag);
        Debug.Log(gameObject);
        Debug.Log(transform);

        print("haha");

        Debug.Log(receiver.isActiveAndEnabled);
        Debug.Log(receiver.enabled);
        receiver.enabled = false;
        Debug.Log(receiver.name);
        Debug.Log(receiver.tag);
        Debug.Log(receiver.gameObject);
        Debug.Log(receiver.transform);


        #endregion



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
