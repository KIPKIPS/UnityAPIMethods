using System.Collections;
using UnityEngine;

public class API_09_Coroutine : MonoBehaviour {
    public GameObject cube;
    private IEnumerator cor;
    private int num = 0;
    // Start is called before the first frame update
    void Start() {
        cube = GameObject.Find("Cube");
        cor = Fade();
        //cube.GetComponent<MeshRenderer>().material.color = Color.black;
        //Debug.Log("主程序执行");
        //Debug.Log("开启协程,准备改变颜色");
        //StartCoroutine(MyCoroutineFunction());//调用协程方法
        //Debug.Log("主程序");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (num==0) 
                num++;
            else 
                num--;
            Debug.Log(num);
            //Debug.Log("start");
        }
        if (num == 1) 
            StartCoroutine(cor);//开启协程
        if (num==0&& cor != null) 
            StopCoroutine(cor);//停止协程
    }
    //协程函数
    IEnumerator Fade() {
        for (;;) {//float i = 0; i <= 2; i += 0.02f
            //cube.GetComponent<MeshRenderer>().material.color = new Color(i,i,i,i);
            Color currentColor = cube.GetComponent<MeshRenderer>().material.color;//获取目标值
            Color targetColor = Color.Lerp(currentColor, Color.black, 0.02f);//设置插值,当前值,目标值,插值时间
            cube.GetComponent<MeshRenderer>().material.color = targetColor;//将插值设置给cube
            //等待0.02秒
            yield return new WaitForSeconds(0.02f);
            //达到目标值则break
            if (Mathf.Abs(Color.black.r - targetColor.r) <=0.01f) 
                break;
        }
        yield return null;
    }

    IEnumerator MyCoroutineFunction() {
        cube.GetComponent<MeshRenderer>().material.color = Color.black;
        //yield return new WaitForSeconds(3);//协程等待
        yield return null;
    }
}
