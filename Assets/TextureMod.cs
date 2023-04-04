using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureMod : MonoBehaviour
{
    Texture2D t2D;
    Texture2D t2D1;
    public GameObject tx;
    private RawImage rawimage2;
    void Start()
    {

        var rawImage = GetComponent<RawImage>();
        rawimage2 = tx.GetComponent<RawImage>();
        t2D = rawImage.texture as Texture2D;
        t2D1 = rawimage2.texture as Texture2D;
        int miplevel = 0;
        Color[] pixall = t2D.GetPixels(miplevel);
        //System.Array.Reverse(pixall, 0, pixall.Length);
        
        //Texture2D texture = new Texture2D(640, 640);
        //tx.GetComponent<Renderer>().material.mainTexture = texture;

        //for (int y = 0; y < texture.height; y++)
        //{
        //    for (int x = 0; x < texture.width; x++)
        //    {
        //        Color color = ((x & y) != 0 ? Color.white : Color.gray);
        //        texture.SetPixel(x, y, color);
        //    }
        //}
        
        var newlistx = new List<Color>();
        var totallength = pixall.Length;
        for(int i=0; i < totallength; i++)
        {
            var colorx = pixall[i];
            if (newlistx.IndexOf(colorx) == -1)
            {
                newlistx.Add(colorx);
            }
        }
        for(int i = 0; i < newlistx.Count; i++)
        {
            print(newlistx[i]);
        }
        for(int i = 0; i < pixall.Length; i++)
        {
            if (pixall[i] == newlistx[2]|| pixall[i] == newlistx[4])
            {
                pixall[i] = Color.white;
            }
        }
        int miplevelx = 0;
        t2D1.SetPixels(pixall, miplevelx);
        t2D1.Apply();
        Debug.Log("all pixels" + pixall.Length);
    }
}
