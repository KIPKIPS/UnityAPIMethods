using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class API_22_CharacterController : MonoBehaviour {
    public CharacterController characterController;
    public float speed = 0;
    // Start is called before the first frame update
    void Start() {
        characterController = GetComponent<CharacterController>();
        speed = 10;
    }

    // Update is called once per frame
    void Update() {
        float h = Input.GetAxis("Horizontal");//X轴的移动
        float v = Input.GetAxis("Vertical");//Z轴的移动
        //characterController.SimpleMove(new Vector3(h,0,v)*speed);//有重力影响
        characterController.Move(new Vector3(h, 0, v) * Time.deltaTime * speed);//无重力影响
        Debug.Log(characterController.isGrounded);
    }

    public void OnControllerColliderHit(ControllerColliderHit hit) {
        Debug.Log(hit.collider);
    }
}
