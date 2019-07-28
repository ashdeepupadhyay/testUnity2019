using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Texture textureBackground;
    public Texture textureTop;
    public Texture bottomLeft;
    public Texture bottomRight;
    Helper createPlanes;
    void Start()
    {
        createPlanes = new Helper();
        createPlanes.Renderer(textureBackground, textureTop, bottomLeft, bottomRight);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            createPlanes.SwapObj();
        }
    }
}
