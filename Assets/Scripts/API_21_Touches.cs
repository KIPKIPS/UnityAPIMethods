using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_21_Touches : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.touches.Length>0) {
            Touch touch1 = Input.touches[0];//第一个手指触摸的封装对象
            TouchPhase tp = touch1.phase;//手指的状态
            //TouchPhase.Began 手指放在屏幕上
            //TouchPhase.Canceled 由系统中断触摸事件
            //TouchPhase.Ended 手指离开屏幕
            //TouchPhase.Moved 手指移动
            //TouchPhase.Stationary 手指静止
            if (tp==0) {
                Debug.Log(touch1.position);//位置
            }
        }
        
    }
}
