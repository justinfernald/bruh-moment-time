using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeClicker : MonoBehaviour
{

    public Camera camera;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                MakeTransparent mt = hit.collider.gameObject.GetComponent<MakeTransparent>();
                if (!mt) return;
                if (mt.hasCube)
                {
                    mt.ShowTransparent();
                }
                Debug.Log("Did Hit");
            }
        }
    }
}
