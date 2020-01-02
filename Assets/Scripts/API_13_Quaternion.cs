using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_13_Quaternion : MonoBehaviour {
    public Transform player;
    public Transform enemy;
    private float startTime = 0;
    // Start is called before the first frame update
    void Start() {
        player = GameObject.Find("Player").transform;
        enemy = GameObject.Find("Enemy").transform;
        //player.rotation=Quaternion.LookRotation(enemy.position-player.position);//瞬间转向,不符合逻辑
        //记录开始时间
        startTime = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update() {
        float currentTime = Time.realtimeSinceStartup;
        if (currentTime-startTime>=3) {
            startTime = currentTime;
            enemy.position = new Vector3(Random.Range(-10, 10), 5, Random.Range(-10, 10));
        }
        Vector3 temp= Vector3.Slerp(player.forward,enemy.position-player.position,Time.deltaTime*2);
        temp.y = 0;//防止对象Y轴发生旋转(弯腰抬头)
        player.forward = temp;
    }
}
