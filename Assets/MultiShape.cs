using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiShape : MonoBehaviour
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
        for (var x = 0; x < t2D.height; x++)
        {
            var y = 1;
            // bool isActive = true;
            while (y < t2D.width)
            {
                t2D1.SetPixel(x, y, Color.white);

                y++;
            }
        }
        for (var x = 0; x < t2D.height; x++)
        {
            var y = 1;
            // bool isActive = true;
            while (y < t2D.width)
            {
                Color px = t2D.GetPixel(x, y-1);
                Color px1 = t2D.GetPixel(x, y);
                if (px == px1 && px!=Color.white)
                {
                    t2D1.SetPixel(x, y, Color.black);
                }
                
                y++;
            }
        }
        t2D1.Apply();
    }
}