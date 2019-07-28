using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomiseColor : MonoBehaviour
{
    MeshRenderer mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = gameObject.GetComponent<MeshRenderer>();
        StartCoroutine("RandomColor");
    }
    IEnumerator RandomColor()
    {
        for(; ; )
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Random.ColorHSV());
            yield return new WaitForSeconds(10.0f);
        }       
    }
}
