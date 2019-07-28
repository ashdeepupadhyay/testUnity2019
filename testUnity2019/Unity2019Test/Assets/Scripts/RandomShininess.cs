using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomShininess : MonoBehaviour
{
    MeshRenderer mat;

    void Start()
    {
        mat = gameObject.GetComponent<MeshRenderer>();
        StartCoroutine("RandomShine");
    }
    IEnumerator RandomShine()
    {
        for (; ; )
        {
            float shininess = Mathf.PingPong(Time.time, 1.0f);
            gameObject.GetComponent<Renderer>().material.SetFloat("_Shininess", shininess);
            yield return new WaitForSeconds(10.0f);
        }
    }
}
