using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInFadeOut : MonoBehaviour
{
    public Color myColor;
    MeshRenderer mat;
    void Start()
    {
        mat=gameObject.GetComponent<MeshRenderer>();
        StartCoroutine(FadeImage());
    }

    IEnumerator FadeImage()
    {
        while (true)
        {
            for (float f = 1f; f >= 0.00f; f -= 0.05f)
            {
                gameObject.GetComponent<Renderer>().material.SetFloat("_Shininess", f);
                yield return new WaitForSeconds(1.0f);
            }
            for (float f = 0.00f; f <= 1f; )
            {
                if(f<0.1f)
                {
                    f += 0.01f;
                }
                else
                {
                    f += 0.05f;
                }
                gameObject.GetComponent<Renderer>().material.SetFloat("_Shininess", f);
                yield return new WaitForSeconds(1.0f);
            }
        }        
    }
}
