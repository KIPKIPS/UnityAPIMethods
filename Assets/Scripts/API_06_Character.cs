using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class API_06_Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("编辑器模式下即可运行");
        Receiver[]receivers = FindObjectsOfType<Receiver>();
        foreach (var r in receivers) {
            Debug.Log(r.name);
        }
    }

    // Update is called once per frame
    void Update() {
    }
}
