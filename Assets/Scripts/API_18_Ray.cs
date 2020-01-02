using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_18_Ray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray=new Ray(transform.position,transform.forward);//起始点和方向
        RaycastHit hit;//碰撞到的物体信息
        //射线检测碰撞
        //bool isCollider = Physics.Raycast(ray, 1);
        //Physics.Raycast的重载方法
        //Physics.Raycast(ray, out hit);
        bool isCollider = Physics.Raycast(ray,out hit,2,LayerMask.GetMask("Water"));//第二个参数layerMask表示可以碰撞的层
        //Physics.RaycastAll()//检测射线范围内的所有物体碰撞信息,Physics.Raycast()只检测碰到的第一个物体,之后的不会去检测
        if (isCollider) {
            Debug.Log(isCollider + " " + hit.transform.name);
        }
        
    }
}
