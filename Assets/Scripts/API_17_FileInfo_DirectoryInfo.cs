using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class API_17_FileInfo_DirectoryInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        statisticFiles(Application.dataPath+ "/FileSystemTest/SonFile_00");
        //Debug.Log(Directory.GetDirectories(Application.dataPath + "/FileSystemTest/SonFile_00").Length);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private int statisticFiles(string directory) {
        int statistic = System.IO.Directory.GetFiles(directory).Length;//获取子文件夹下所有文件(包含文件夹和文件,不包含文件夹的.meta文件)
        string[] directories = System.IO.Directory.GetDirectories(directory);//得到文件夹目录下所有的子文件夹名字
        return statistic;
    }
}
