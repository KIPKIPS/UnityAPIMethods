using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.UI;

public class API_16_ApplicationPath : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        //Debug.Log(Application.dataPath);
        //Debug.Log(Application.streamingAssetsPath);
        //Debug.Log(Application.persistentDataPath);
        //Debug.Log(Application.temporaryCachePath);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.S))
            //ScreenCapture.CaptureScreenshot("屏幕截图");
            CaptureScreenshot(new Rect(new Vector2(0, 0), new Vector2(Screen.width, Screen.height)));
        UnityEditor.EditorApplication.isPlaying = Input.GetKeyDown(KeyCode.Space) ? false : true;//编辑器模式下退出运行
    }
    Texture2D CaptureScreenshot(Rect rect) {
        int picNums = 0;//已存在固定格式的文件数量
        // 创建空纹理
        Texture2D screenShot = new Texture2D((int)rect.width, (int)rect.height, TextureFormat.RGB24, false);
        screenShot.ReadPixels(rect, 0, 0);// 读取屏幕像素信息并存储为纹理数据
        //screenShot.Apply();
        byte[] bytes = screenShot.EncodeToPNG();//将纹理数据处理成png图片文件
        picNums = GetPicNums(Application.dataPath + "/Screenshots/", ".png");//后缀为.png的文件数量
        string filename = Application.dataPath + "/Screenshots/Screenshot" + picNums.ToString() + ".png";//迭代每次操作的对象命名
        File.WriteAllBytes(filename, bytes);//存储数据
        Debug.Log(string.Format("Success/Screenshot" + picNums));
        //返回Texture2d对象
        return screenShot;
    }
    public int GetPicNums(string path, string suffix) {
        int num = 0;
        string[] fileName = Directory.GetFiles(path);
        foreach (var file in fileName) {
            num += file.Substring(file.Length - 4) == suffix ? 1 : 0;
        }
        return num;
    }
}
