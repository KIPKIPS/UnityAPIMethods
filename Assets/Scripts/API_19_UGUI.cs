using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//代码添加的方式实现UGUI的事件监听
public class API_19_UGUI : MonoBehaviour
{
    public Button btn;
    public Slider slider;
    public Toggle toggle;
    public Dropdown dropDown;
    // Start is called before the first frame update
    void Start()
    {
        //Button
        btn = GameObject.Find("Button").GetComponent<Button>();//得到button后在onClick上添加监听器
        btn.onClick.AddListener(BtnOnClick);//添加方法

        //Slider
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        slider.onValueChanged.AddListener(SliderValueChanged);

        //Toggle
        toggle = GameObject.Find("Toggle").GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(ToggleValueChanged);

        //DropDown
        dropDown = GameObject.Find("Dropdown").GetComponent<Dropdown>();
        dropDown.onValueChanged.AddListener(DropValueChanged);
    }

    //Button的OnClick方法
    void BtnOnClick()
    {
        Debug.Log("Button.OnClick");
    }
    //Slider的ValueChanged方法
    void SliderValueChanged(float value)
    {
        Debug.Log(value);//value值为滑杆的值
    }
    //Toggle的ValueChanged方法
    void ToggleValueChanged(bool value)
    {
        Debug.Log(value);
    }
    //DropDown的ValueChanged方法
    void DropValueChanged(int value)
    {
        Debug.Log(value);
    }
    void Update()
    {

    }
}
