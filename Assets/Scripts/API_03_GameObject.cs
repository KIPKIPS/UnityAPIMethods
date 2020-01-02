using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_03_GameObject : MonoBehaviour {
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        //第一种创建方法,直接new一个空的游戏物体
        //GameObject go=new GameObject("MyGameObject");

        //第二种根据Prefab或者场景中的物体来创建
        //GameObject.Instantiate(prefab);

        //第三种创建方法,根据Primitive给定的模板
        GameObject go=GameObject.CreatePrimitive(PrimitiveType.Capsule);
        go.AddComponent<Rigidbody>();//添加组件
        go.AddComponent<API_02_Time>();//添加自定义的脚本

        Debug.Log(go.activeInHierarchy);//检查游戏物体是否处于激活状态
        //go.SetActive(false);
        Debug.Log(go.activeInHierarchy);

        //两种方法
        Object[] obj1 =FindObjectsOfType(typeof(Rigidbody));//获取所有有Rigidbody组件的对象并存入一个对象数组
        Rigidbody[] obj2 = FindObjectsOfType<Rigidbody>();//获取所有有Rigidbody组件的对象并存入一个对象数组
        foreach (Rigidbody VARIABLE in obj2) {
            Debug.Log(VARIABLE.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
