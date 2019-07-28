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
        zoomin.onClick.AddListener(() =>
        {
            Helper.backgroundGameObj.transform.localScale = new Vector3(Helper.backgroundGameObj.transform.localScale.x + 0.1f, Helper.backgroundGameObj.transform.localScale.y + 0.1f, Helper.backgroundGameObj.transform.localScale.z);
        });
        zoomout.onClick.AddListener(() =>
        {
            if(Helper.backgroundGameObj.transform.lossyScale.x>0)
            {
                Helper.backgroundGameObj.transform.localScale = new Vector3(Helper.backgroundGameObj.transform.localScale.x - 0.1f, Helper.backgroundGameObj.transform.localScale.y - 0.1f, Helper.backgroundGameObj.transform.localScale.z);
            }
        });
    }
}
