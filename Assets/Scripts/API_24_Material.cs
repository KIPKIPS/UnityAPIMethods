using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_24_Material : MonoBehaviour
{
    public Material material1;
    public Material material2;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        material1 = GameObject.Find("Cube1").GetComponent<MeshRenderer>().material;
        material2= GameObject.Find("Cube2").GetComponent<MeshRenderer>().material;
        material2.color=Color.black;
        material1.mainTexture = Resources.Load<Texture>("Texture/June");
        material2.mainTexture = Resources.Load<Texture>("Texture/Summer");
    }

    // Update is called once per frame
    void Update() {
        material1.color = Color.Lerp(material1.color, Color.black, Time.deltaTime);
    }
}
