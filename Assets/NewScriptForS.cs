using System.Collections.Generic;
using UnityEngine;

public class NewScriptForS : MonoBehaviour
{
    public Texture2D image;
    public Texture2D t2D1;
    public int threshold = 128;
    public int minSize = 10;
    public int maxSize = 100;
    private void Start()
    {
        for (var x = 0; x < t2D1.height; x++)
        {
            var y = 0;
            // bool isActive = true;
            while (y < t2D1.width)
            {
               // Color px = t2D1.GetPixel(x, y);
                t2D1.SetPixel(x, y, Color.white);
                y++;
            }
        }
        List<Vector2> spotx = new List<Vector2>();
        spotx = DetectSpots();
        for(int i = 0; i < spotx.Count; i++)
        {
            var m=Mathf.FloorToInt(spotx[i].x);
            var n= Mathf.FloorToInt(spotx[i].y);
            t2D1.SetPixel(m,n, Color.black);
        }
    }

    public List<Vector2> DetectSpots()
    {
        List<Vector2> spots = new List<Vector2>();
        Color[] pixels = image.GetPixels();
        for (int i = 0; i < pixels.Length; i++)
        {
            if (pixels[i].grayscale < threshold / 255f)
            {
                Vector2 center = new Vector2(i % image.width, i / image.width);
                bool isSpot = true;
                for (int j = 0; j < spots.Count; j++)
                {
                    if (Vector2.Distance(center, spots[j]) < minSize)
                    {
                        isSpot = false;
                        break;
                    }
                }
                if (isSpot)
                {
                    spots.Add(center);
                }
            }
        }
        return spots;
    }
}

