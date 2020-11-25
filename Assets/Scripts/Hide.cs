using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Hide : MonoBehaviour
{
    public Button hide;

    private GameObject targetCube;

    public GameObject insideCube;
    public GameObject insideCube1;
    public GameObject insideCube2;
    public GameObject insideCube3;
    public GameObject insideCube4;
    public GameObject insideCube5;
    public GameObject insideCube6;
    public GameObject insideCube7;
    public GameObject insideCube8;

    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Stop();

        targetCube = GameObject.Find("targetCube");
        
        hideInside(insideCube);
        hideInside(insideCube1);
        hideInside(insideCube2);
        hideInside(insideCube3);
        hideInside(insideCube4);
        hideInside(insideCube5);
        hideInside(insideCube6);
        hideInside(insideCube7);
        hideInside(insideCube8);

        Material targetCubeMaterial = targetCube.GetComponent<Renderer>().material;

        hide.onClick.AddListener(TasksOnClick);
        UnityEngine.Debug.Log("Hide Button Clicked");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TasksOnClick()
    {
        Color oldColor = targetCube.GetComponent<Renderer>().material.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, 0);
        targetCube.GetComponent<Renderer>().material.SetColor("_Color", newColor);
    }

    void hideInside(GameObject obj)
    {
        Color oldColor = obj.GetComponent<Renderer>().material.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, 0);
        obj.GetComponent<Renderer>().material.SetColor("_Color", newColor);
    }
}
