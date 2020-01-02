using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_12_Random : MonoBehaviour {
    public GameObject prefab;
    // Start is called before the first frame update
    void Start() {
        //动态加载资源,在Assets目录下新建Resources文件夹,加载资源放入其中,以Resources文件夹为根目录
        prefab = Resources.Load("Prefabs/MyCube")as GameObject;
    }

    // Update is called once per frame
    void Update() {
        StartCoroutine(Create());
        
    }

    public IEnumerator Create() {
        GameObject go = Instantiate(prefab);
        go.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        //  go.transform.position = new Vector3(10, 0, 0);
        go.AddComponent<Rigidbody>();
        //Vector3 v3=Random.insideUnitSphere * 5;
        go.transform.position = new Vector3(Random.Range(0,10), 0, Random.Range(0, 10));
        yield return new WaitForSeconds(10);
        Destroy(go);
    }
}
