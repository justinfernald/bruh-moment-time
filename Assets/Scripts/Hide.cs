using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Hide : MonoBehaviour
{
    public Button hide;

    private GameObject targetCube;

    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Stop();

        targetCube = GameObject.Find("targetCube");

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
}
