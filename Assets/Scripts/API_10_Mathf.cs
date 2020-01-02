using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class API_10_Mathf : MonoBehaviour {
    public GameObject cube;
    public int rotationSpeed = 400;
    public int scaleSpeed = 5;
    private int moveSpeed = 3;
    private int scale = 3;
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 400;
        scaleSpeed = 5;
        scale = 3;
        moveSpeed = 3;
        cube.transform.position=new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update() {
        
        float x = cube.transform.position.x;
        //float target = Mathf.Lerp(x, 10, 0.1f);//先快后慢
        float target = Mathf.MoveTowards(x, 10, 0.1f);//匀速
        //cube.transform.position = new Vector3(target, 0, 0);
        //Debug.Log(Mathf.PingPong(Time.time,10));//Mathf.PingPong(a,b)a为变动的值,在a的初始值和length之间来回变更
        cube.transform.position=new Vector3(Mathf.PingPong(Time.time*moveSpeed,20),0,0);
        cube.transform.eulerAngles=new Vector3(Mathf.PingPong(-Time.time* rotationSpeed, 360), Mathf.PingPong(-Time.time * rotationSpeed, 360), Mathf.PingPong(-Time.time * rotationSpeed, 360));
        cube.transform.localScale=new Vector3(Mathf.PingPong(Time.time*scaleSpeed,scale), Mathf.PingPong(Time.time * scaleSpeed, scale), Mathf.PingPong(Time.time * scaleSpeed, scale));
    }
}
