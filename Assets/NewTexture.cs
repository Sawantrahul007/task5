using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewTexture : MonoBehaviour
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

        //int miplevel = 0;
        Color[] pixall = t2D.GetPixels(0,0,640,640);
        ////System.Array.Reverse(pixall, 0, pixall.Length);

        ////Texture2D texture = new Texture2D(640, 640);
        ////tx.GetComponent<Renderer>().material.mainTexture = texture;

        ////for (int y = 0; y < texture.height; y++)
        ////{
        ////    for (int x = 0; x < texture.width; x++)
        ////    {
        ////        Color color = ((x & y) != 0 ? Color.white : Color.gray);
        ////        texture.SetPixel(x, y, color);
        ////    }
        ////}

        var newlistx = new List<Color>();
        var newlisty = new List<Color>();
        var totallength = pixall.Length;
        for (int i = 0; i < totallength; i++)
        {
            
            var colorx = pixall[i];
            if (colorx.r > 0.9f && colorx!=Color.white)
            {
                newlistx.Add(colorx);

            }else if(colorx.g > 0.5f && colorx != Color.white && colorx.r < 0.2f)
            {
                Debug.Log("ll");
                newlisty.Add(colorx);
            }
            
            
        }

        for (int i = 0; i < newlistx.Count; i++)
        {
            print(newlistx[i]);
        }
        for (int i = 0; i < newlisty.Count; i++)
        {
            print(newlisty[i]);
        }
        //for (int i = 0; i < pixall.Length; i++)
        //{
        //    if (pixall[i] == newlistx[2] || pixall[i] == newlistx[4])
        //    {
        //        pixall[i] = Color.white;
        //    }
        //}
        for (var x = 0; x < t2D.height; x++)
        {
            var y = 0;
           // bool isActive = true;
            while (y < t2D.width)
            {
                Color px = t2D.GetPixel(x, y);
                t2D1.SetPixel(x, y, Color.white);
               
                //if (px != Color.white)
                //{
                //    Debug.Log("gg");
                    
                //    isActive = false;
                //    //t2D1.Apply();
                //}
                y++;
            }
        }
        for (var x = 0; x < t2D.height; x++)
        {
            var y = 0;
            bool isActive = true;
            while (y < t2D.width && isActive)
            {
                Color px = t2D.GetPixel(x, y);
                if (px != Color.white)
                {
                    Debug.Log("gg");
                    t2D1.SetPixel(x, y, Color.red);
                    isActive = false;
                    //t2D1.Apply();
                }
                y++;
            }
            var y1 = t2D.width;
            bool isActive1 = true;
            while (y1 > 0 && isActive1)
            {
                Color px = t2D.GetPixel(x, y1);
                if (px != Color.white)
                {
                    Debug.Log("gg");
                    t2D1.SetPixel(x, y1, Color.red);
                    isActive1 = false;
                    //t2D1.Apply();
                }
                y1--;
            }
        }
        //for (var x = t2D.height; x > 0; x--)
        //{
            
        //}
        t2D1.Apply();
        //int miplevelx = 0;
        //t2D1.SetPixels(pixall, miplevelx);
        //t2D1.Apply();
        //Debug.Log("all pixels" + pixall.Length);
    }
}
