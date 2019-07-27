using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Texture textureBackground;
    public Texture textureTop;
    void Start()
    {
        Helper.Renderer(textureBackground, textureTop, textureTop, textureTop);
    }
}
