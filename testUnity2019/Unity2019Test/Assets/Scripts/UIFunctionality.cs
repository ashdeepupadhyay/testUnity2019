using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFunctionality : MonoBehaviour
{
    [SerializeField]
    private Button zoomin;
    [SerializeField]
    private Button zoomout;
    [SerializeField]
    private Button swap;
    Helper createPlanes;
    void Start()
    {
        createPlanes = new Helper();
        swap.onClick.AddListener(() => { createPlanes.SwapObj(); });
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
