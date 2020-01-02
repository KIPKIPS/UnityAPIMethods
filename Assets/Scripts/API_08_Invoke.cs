using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class API_08_Invoke : MonoBehaviour {
    private float timeCurrent = 0;
    private float timeStart = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("Attack",2);//两秒之后调用Invoke里面的方法
        timeStart = Time.realtimeSinceStartup;
        Debug.Log("Time start : "+ timeStart);
        InvokeRepeating("Attack",3,1);
        InvokeRepeating("TimeCurrent", 3, 1);
    }

    // Update is called once per frame
    void Update() {
        timeCurrent = Time.realtimeSinceStartup;
        if (timeCurrent- timeStart >= 10) {
            CancelInvoke();// 可以不指定方法名,取消调用队列里所有的方法
        }
        //Debug.Log(IsInvoking("Attack"));//判断Attack方法是否执行
    }

    void Attack() {
        Debug.Log("Attacking");
    }

    void TimeCurrent() {
        Debug.Log("Current time is : "+timeCurrent);
    }
}
