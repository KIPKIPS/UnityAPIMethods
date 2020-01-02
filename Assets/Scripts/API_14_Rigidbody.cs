using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_14_Rigidbody : MonoBehaviour {
    public Rigidbody cubeRgd;

    public Transform cubeTrans;
    public Transform enemyTrans;

    public float force = 6;
    // Start is called before the first frame update
    void Start() {
        cubeRgd = GetComponent<Rigidbody>();
        cubeTrans = this.transform;
        enemyTrans = GameObject.Find("Enemy").transform;
        force = 6;
    }

    // Update is called once per frame
    void Update()
    {
        //运动的两种方式
        //cubeRgd.position=cubeRgd.transform.position+Vector3.forward* Time.deltaTime * 3;
        //cubeRgd.MovePosition(cubeRgd.transform.position + Vector3.forward * Time.deltaTime * 3);//插值运动,适用于持续运动 
        
        //旋转
        Vector3 dir = enemyTrans.position - cubeTrans.position;
        dir.y = 0;
        Quaternion target=Quaternion.LookRotation(dir);
        cubeRgd.MoveRotation(Quaternion.Lerp(cubeTrans.rotation,target,Time.deltaTime*10));

        //AddForce
        cubeRgd.AddForce(dir*force);//通过施加力的方式使物体做匀加速运动
    }
}
