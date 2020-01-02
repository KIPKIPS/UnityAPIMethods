using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_15_Camera : MonoBehaviour {
    public Camera c;
    // Start is called before the first frame update
    void Start() {
        c = GameObject.Find("Main Camera").GetComponent<Camera>();
        //camera=Camera.main;//通过标签查找,Tag必须为MainCamera
    }

    // Update is called once per frame
    void Update() {
        Ray ray=c.ScreenPointToRay(Input.mousePosition);//将屏幕坐标转换成射线
        //检测碰到的物体
        RaycastHit hit;
        bool isHit=Physics.Raycast(ray, out hit);
        if (isHit&&Input.anyKeyDown) {
            Debug.Log(hit.collider);
        }
        //绘制射线(两种)
        //Debug.DrawRay(ray.origin,ray.direction*100,Color.green);
        Debug.DrawLine(ray.origin, ray.origin+ray.direction*100,Color.green,2);//第四个参数是射线可以存在的时间
    }
}
