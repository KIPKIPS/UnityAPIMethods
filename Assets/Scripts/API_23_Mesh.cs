using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_23_Mesh : MonoBehaviour
{
    private MeshFilter meshFilter;//获取MeshFilter组件
    public Mesh targetMesh_Cube;//目标Mesh
    public Mesh targetMesh_Capsule;//目标Mesh
    public Mesh targetMesh_Sphere;//目标Mesh
    private GameObject go;
    private Rigidbody rigidbody;
    private int before;
    public int isBig;
    // Start is called before the first frame update
    void Start() {
        go = GameObject.Find("Cube");
        rigidbody = GetComponent<Rigidbody>();
        isBig = 0;
    }

    // Update is called once per frame
    void Update() {
        if (Input.anyKeyDown) {
            int temp = Random.Range(0, 3);
            before = temp;
            Change(temp);
        }
        
    }

    void Change(int num) {
        //圆柱
        if (num==0) {
            meshFilter = GetComponent<MeshFilter>();
            meshFilter.sharedMesh = targetMesh_Capsule;//将mesh复制一份,将复制品修改之后赋值给目标
            Remove(before,num);
        }
        //正方体
        if (num == 1)
        {
            meshFilter = GetComponent<MeshFilter>();
            meshFilter.sharedMesh = targetMesh_Cube;//将mesh复制一份,将复制品修改之后赋值给目标
            Remove(before, num);
        }
        //圆
        if (num == 2)
        {
            meshFilter = GetComponent<MeshFilter>();
            meshFilter.sharedMesh = targetMesh_Sphere;//将mesh复制一份,将复制品修改之后赋值给目标
            Remove(before, num);
        }
    }

    void Remove(int before,int now) {
        if (before==0) {
            Destroy(go.GetComponent<CapsuleCollider>());//移除旧的boxcollider
        }
        if (now==0) {
            go.AddComponent<CapsuleCollider>();//添加新的圆柱体collider
        }
        if (before == 1)
        {
            Destroy(go.GetComponent<BoxCollider>());//移除旧的boxcollider
        }
        if (now == 1)
        {
            go.AddComponent<BoxCollider>();//添加新的圆柱体collider
        }
        if (before == 2)
        {
            Destroy(go.GetComponent<SphereCollider>());//移除旧的boxcollider
        }
        if (now == 2)
        {
            go.AddComponent<SphereCollider>();//添加新的圆柱体collider
        }

    }
    // 碰撞开始
    void OnCollisionEnter(Collision collision) {
        isBig = isBig == 0 ? 1 : 0;
        Debug.Log(isBig);
        transform.localScale = isBig==0? new Vector3(1,1,1): new Vector3(4, 4, 4);
    }

    // 碰撞结束
    void OnCollisionExit(Collision collision) {
        
    }

    // 碰撞持续中
    void OnCollisionStay(Collision collision)
    {
        rigidbody.AddForce(Vector3.up * 200);
    }
}
