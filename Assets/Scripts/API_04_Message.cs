using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_04_Message : MonoBehaviour {
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        //target.BroadcastMessage("Attack",null,SendMessageOptions.DontRequireReceiver);//设置不需要接受者,物体及其子物体都会收到消息
        //target.SendMessage("Attack",null, SendMessageOptions.DontRequireReceiver);//仅该物体会收到消息
        target.SendMessageUpwards("Attack", null, SendMessageOptions.DontRequireReceiver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
