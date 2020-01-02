using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_11_Input : MonoBehaviour {
    public GameObject cube;
    public float speed = 5;
    // Start is called before the first frame update
    void Start() {
        speed = 5;
        cube=GameObject.Find("Cube");
    }

    private float jump = 0;
    // Update is called once per frame
    void Update() {
        if (Input.anyKeyDown) {
            //Debug.Log("AnyKey Down");//任意键按下触发
        }
        Debug.Log(Input.mousePosition);//获取鼠标位置
        if (Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.D)) {
            //Debug.Log(Input.GetAxis("Horizontal"));//获取一个渐变的值//按下AD键之后      
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S)) {
            //Debug.Log(Input.GetAxis("Vertical"));//获取一个渐变的值//按下WS键之后      
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            cube.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0));
        }
        //控制物体的移动
        cube.transform.Translate(new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*speed, 0, Input.GetAxis("Vertical") *Time.deltaTime* speed));
       
    }
}
