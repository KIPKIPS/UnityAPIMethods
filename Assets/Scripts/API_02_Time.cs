using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class API_02_Time : MonoBehaviour {
    public Transform cube;

    public float scale = 1;

    public int loopCount = 10000;
    // Start is called before the first frame update
    void Start() {
        cube = GameObject.Find("Cube").transform;
        //Debug.Log("Time.deltaTime:" + Time.deltaTime);
        //Debug.Log("Time.fixedDeltaTime:" + Time.fixedDeltaTime);
        //Debug.Log("Time.fixedTime:" + Time.fixedTime);
        //Debug.Log("Time.frameCount:" + Time.frameCount);
        //Debug.Log("Time.realtimeSinceStartup:" + Time.realtimeSinceStartup);
        //Debug.Log("Time.smoothDeltaTime:" + Time.smoothDeltaTime);
        //Debug.Log("Time.time:" + Time.time);
        //Debug.Log("Time.timeScale:" + Time.timeScale);
        //Debug.Log("Time.timeSinceLevelLoad:" + Time.timeSinceLevelLoad);
        //Debug.Log("Time.unscaledTime:" + Time.unscaledTime);

        //利用Time.realtimeSinceStartup计算性能
        float timeStartM1 = Time.realtimeSinceStartup;
        for (int i = 0; i < loopCount; i++)
            Method1();
        float timeEndM1 = Time.realtimeSinceStartup;
        float timeStartM2 = Time.realtimeSinceStartup;
        for (int i = 0; i < loopCount; i++)
            Method2();
        float timeEndM2 = Time.realtimeSinceStartup;
        //Debug.Log((timeEndM1 - timeStartM1)+" "+ (timeEndM2 - timeStartM2));
        //Debug.Log("Method" + (timeEndM1 - timeStartM1 > timeEndM2 - timeStartM2 ? 2 : 1) + " is better");
        float more = timeEndM1 - timeStartM1 > timeEndM2 - timeStartM2 ? timeEndM1 - timeStartM1 : timeEndM2 - timeStartM2;
        float less = timeEndM1 - timeStartM1 < timeEndM2 - timeStartM2 ? timeEndM1 - timeStartM1 : timeEndM2 - timeStartM2;
        string temp = timeEndM1 - timeStartM1 < timeEndM2 - timeStartM2 ? "Method1比Method2" : "Method2比Method1";
        //Debug.Log("Method1耗时"+(timeEndM1 - timeStartM1)+",Method2耗时"+(timeEndM2 - timeStartM2));
        Debug.Log(temp + "性能优化" + (more - less) / more * 100 + "%");
    }

    // Update is called once per frame
    void Update() {
        //Debug.Log("Time.deltaTime:"+Time.deltaTime);//每一帧的时间
        //Debug.Log("Time.fixedDeltaTime:" + Time.fixedDeltaTime);
        //Debug.Log("Time.fixedTime:" + Time.fixedTime);
        //Debug.Log("Time.frameCount:" + Time.frameCount);//计算帧数
        //Debug.Log("Time.realtimeSinceStartup:" + Time.realtimeSinceStartup);//开始到现在运行的时间(游戏暂停也会累计)
        //Debug.Log("Time.smoothDeltaTime:" + Time.smoothDeltaTime);//平滑时间
        //Debug.Log("Time.time:" + Time.time);
        //Debug.Log("Time.timeScale:" + Time.timeScale);//时间倍率
        //Debug.Log("Time.timeSinceLevelLoad:" + Time.timeSinceLevelLoad);//场景加载开始计时,切换场景时重新计时
        //Debug.Log("Time.unscaledTime:" + Time.unscaledTime);
        cube.Translate(Vector3.forward * Time.deltaTime * 2);
        Time.timeScale = scale;//可以用作控制时间的倍率,暂停游戏,值为0时可以暂停所有与Time.deltaTime有关的物体运动
    }

    void Method1() {
        int i = 1+1;
    }

    void Method2() {
        int i = 10 * 10*6*5*7*5*5*5*5;
        i *= 2;
        float a = 100 / 45f;
    }
}
