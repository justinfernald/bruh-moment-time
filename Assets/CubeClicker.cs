using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeClicker : MonoBehaviour
{
    public Text trialText;
    public int trialCount = 10;

    public Camera camera;


    void Start()
    {
        trialText.text = "" + trialCount;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity) && trialCount >= 0)
            {
                MakeTransparent mt = hit.collider.gameObject.GetComponent<MakeTransparent>();
                if (!mt) return;
                trialText.text = "" + --trialCount;
                if (mt.hasCube)
                {
                    trialText.text = "Yay! You did it!";
                    mt.ShowTransparent();
                } else if(trialCount <= 0)
                {
                    trialText.text = "You lose!";
                }

                
                Debug.Log("Did Hit");
            }
        }
    }
}
