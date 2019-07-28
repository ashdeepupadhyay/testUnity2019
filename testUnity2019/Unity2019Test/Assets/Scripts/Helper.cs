using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helper 
{
    public static GameObject backgroundGameObj;
    public static GameObject topGameObj;
    public static GameObject bottomLeftGamObj;
    public static GameObject bottomRightGameObj;
    public static GameObject CreatePlane(float width,float height,bool collider,Texture texture)
    {
        GameObject go = new GameObject("Plane");
        MeshFilter mf = go.AddComponent(typeof(MeshFilter)) as MeshFilter;
        MeshRenderer mr = go.AddComponent(typeof(MeshRenderer)) as MeshRenderer;
        Mesh m = new Mesh();
        m.vertices = new Vector3[]
        {
            new Vector3(0,0,0),
            new Vector3(width,0,0),
            new Vector3(width,height,0),
            new Vector3(0,height,0)
        };

        m.uv = new Vector2[]
        {
            new Vector2(0,0),
            new Vector2(0,1),
            new Vector2(1,1),
            new Vector2(1,0)
        };

        m.triangles = new int[] { 0, 1, 2, 0, 2, 3 };
        mf.mesh = m;
        if(collider)
        {
            (go.AddComponent(typeof(MeshCollider)) as MeshCollider).sharedMesh=m;

        }
        mr.material = new Material(Shader.Find("Specular"));
        go.GetComponent<Renderer>().material.mainTexture = texture;
        m.RecalculateBounds();
        m.RecalculateNormals();

        return go;
    }
    public static void RotateAroundY(GameObject obj)
    {
        Vector3 rot = obj.transform.rotation.eulerAngles;
        rot = new Vector3(rot.x, rot.y + 180, rot.z);
        obj.transform.rotation = Quaternion.Euler(rot);
    }
    public static void Renderer(Texture background,Texture top,Texture bottomLeft,Texture bottomRight)
    {
        backgroundGameObj = CreatePlane(7, 7, true, background);
        RotateAroundY(backgroundGameObj);

        topGameObj = CreatePlane(1, 1, true, top);
        RotateAroundY(topGameObj);
        topGameObj.transform.SetParent(backgroundGameObj.transform);
        topGameObj.transform.position = new Vector3(-1, 4, -0.1f);
        topGameObj.transform.localScale = new Vector3(5, 2, 1);
        topGameObj.AddComponent<FadeInFadeOut>();

        bottomLeftGamObj = CreatePlane(1, 1, true, top);
        bottomLeftGamObj.transform.SetParent(backgroundGameObj.transform);
        RotateAroundY(bottomLeftGamObj);
        bottomLeftGamObj.transform.position = new Vector3(-1, 1, -0.1f);
        bottomLeftGamObj.transform.localScale = new Vector3(2, 2, 1);
        bottomLeftGamObj.AddComponent<RandomiseColor>();

        bottomRightGameObj = CreatePlane(1, 1, true, top);
        RotateAroundY(bottomRightGameObj);
        bottomRightGameObj.transform.SetParent(backgroundGameObj.transform);
        bottomRightGameObj.transform.position = new Vector3(-4, 1, -0.1f);
        bottomRightGameObj.transform.localScale = new Vector3(2, 2, 1);
        bottomRightGameObj.AddComponent<RandomShininess>();
    }

    public static void swap()
    {
        float temp=topGameObj.transform.position.y;
        topGameObj.transform.position = new Vector3(topGameObj.transform.position.x, bottomRightGameObj.transform.position.y, topGameObj.transform.position.z);
        bottomRightGameObj.transform.position = new Vector3(bottomRightGameObj.transform.position.x, temp, bottomRightGameObj.transform.position.z);
        bottomLeftGamObj.transform.position = new Vector3(bottomLeftGamObj.transform.position.x, temp, bottomLeftGamObj.transform.position.z);
    }
}
