using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTransparent : MonoBehaviour
{
    public bool hasCube = false;
    bool isTransparent = false;
    float totalTimeSteps = 0;
    
    void Start()
    {
        // capture changes in sliders and change transparency
        //transparencySlider.onValueChanged.AddListener(delegate { ChangeMaterial(currentGameObject.GetComponent<Renderer>().material, 1); });
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTransparent) return;
        totalTimeSteps += Time.deltaTime;
        ChangeMaterial(gameObject.GetComponent<Renderer>().material, 1f - Mathf.Clamp(totalTimeSteps / 5, 0f, 1f));
    }

    public void ShowTransparent()
    {
        isTransparent = true;
        totalTimeSteps = 0;
    }

    public void RemoveTransparent()
    {
        isTransparent = false;
        totalTimeSteps = 0;
        ChangeMaterial(gameObject.GetComponent<Renderer>().material, 1f);
    }

    void ChangeMaterial(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);
    }
}
