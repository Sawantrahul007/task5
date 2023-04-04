using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReWay : MonoBehaviour
{
    //Texture2D t2D;
    //Texture2D t2D1;
    //public GameObject tx;
    //private RawImage rawimage2;
    //private Color j;
    //private float t = 0;
    //private int n;
    //private int o;
    //private int k;
    //private int l;
    //Vector2Int[] sortedList2 = new Vector2Int[640 * 640];
    //bool[] sortedList2Tracker = new bool[640 * 640];
    //List<Vector2Int> l2 = new List<Vector2Int>();
    //void Start()
    //{

    //    var rawImage = GetComponent<RawImage>();
    //    rawimage2 = tx.GetComponent<RawImage>();
    //    t2D = rawImage.texture as Texture2D;
    //    sortedList2 = new Vector2Int[t2D.width * t2D.height];
    //    t2D1 = rawimage2.texture as Texture2D;
    //    for (var x = 0; x < t2D.height; x++)
    //    {
    //        var y = 0;
    //        // bool isActive = true;
    //        while (y < t2D.width)
    //        {
    //            // Color px = t2D.GetPixel(x, y);
    //            t2D1.SetPixel(x, y, Color.white);
    //            y++;
    //        }
    //    }
    //    //var newlistx = new List<Color>();
    //    List<Vector2Int> differentCo = new List<Vector2Int>();
    //    List<Vector2Int> differentColourPositions = new List<Vector2Int>();
    //    List<Vector2Int> sortedList = new List<Vector2Int>();

    //    for (var x = 0; x < t2D.height; x++)
    //    {
    //        var y = 0;

    //        //bool isCActive = false;
    //        var xm = x;
    //        while (y < t2D.width)
    //        {
    //            bool isActive = true;
    //            Color px = t2D.GetPixel(x, y);
    //            //Color px1 = t2D.GetPixel(x, y - 1);
    //            //if (px != px1)
    //            //{
    //            //    t2D1.SetPixel(x, y, px1);
    //            //    //var m = 0;
    //            //    //var n = 0;
    //            //    //while (isActive)
    //            //    //{
    //            //    //    m++;
    //            //    //    Color px2 = t2D.GetPixel(x, y + 1);
    //            //    //    if (px != px2)
    //            //    //    {
    //            //    //        isActive = false;
    //            //    //    }
    //            //    //}
    //            //    //Debug.Log(m);
    //            //    //if (xm == x)
    //            //    //{
    //            //    //    differentColourPositions.Add(new Vector2Int(x, y));
    //            //    //}

    //            //}

    //            if (px != Color.white)
    //            {
    //                differentCo.Add(new Vector2Int(x, y));
    //                //Debug.Log(t2D.GetPixel(x, y));
    //                if (t == 0)
    //                {
    //                    j = t2D.GetPixel(x, y);
    //                    differentColourPositions.Add(new Vector2Int(x, y));
    //                }
    //                t++;
    //                //differentColourPositions.Add(t2D.GetPixel(x, y));
    //                //Debug.Log("gg");
    //                //Debug.Log(y + "inside");

    //                t2D1.SetPixel(x, y, Color.red);
    //                // Vector2Int c = new Vector2Int(x,y);
    //                while (isActive)
    //                {
    //                    if (j == t2D.GetPixel(x, y))
    //                    {
    //                        differentColourPositions.Add(new Vector2Int(x, y));
    //                    }
    //                    //differentColourPositions.Add(new Vector2Int(x, y));
    //                    Color px1 = t2D.GetPixel(x, y);
    //                    if (px1 == Color.white && y < t2D.width)
    //                    {
    //                        t2D1.SetPixel(x, y, Color.red);
    //                        isActive = false;

    //                    }
    //                    y++;
    //                }
    //                differentCo.Add(new Vector2Int(x, y));
    //                var f = (differentCo[0].x + differentCo[1].x) / 2;
    //                var g = (differentCo[0].y + differentCo[1].y) / 2;
    //                sortedList.Add(new Vector2Int(f, g));
    //                t2D1.SetPixel(f, g, Color.black);
    //                differentCo.Clear();
    //                //maxDist=Vector2Int.Distance( new Vector2Int(x,y), c);
    //                //if(Vector2Int.Distance(new Vector2Int(x, y), c) > maxDist)
    //                //{
    //                //    maxDist = Vector2Int.Distance(new Vector2Int(x, y), c);
    //                //    var mx = x;
    //                //    var my=y;

    //                //}

    //                //Debug.Log(y + "Oustide");
    //                //Debug.Log(differentColourPositions.Count);
    //                //for (int i = 0; i < differentColourPositions.Count; i++)
    //                //{
    //                //    print(differentColourPositions[i]);
    //                //}
    //                //differentColourPositions.Clear();
    //                //Debug.Log(differentColourPositions.Count+"xfg");

    //                //isCActive = true;
    //                //t2D1.Apply();
    //            }
    //            y++;
    //        }
    //        //var y1 = t2D.width;
    //        //bool isActive1 = true;
    //        //while (y1 > 0 && isActive1)
    //        //{
    //        //    Color px = t2D.GetPixel(x, y1);
    //        //    if (px != Color.white)
    //        //    {
    //        //        Debug.Log("gg");
    //        //        t2D1.SetPixel(x, y1, Color.red);
    //        //        isActive1 = false;
    //        //        //t2D1.Apply();
    //        //    }
    //        //    y1--;
    //        //}
    //    }
    //    //sortedList.Sort((a, b) => a.x.CompareTo(b.x));
    //    //for (int i = 1; i < sortedList.Count - 1; i++)
    //    //{

    //    //    if (sortedList[i - 1].y == sortedList[i].y || sortedList[i - 1].y == (sortedList[i].y + 1) || sortedList[i - 1].y == (sortedList[i].y - 1) && sortedList[i].x == (sortedList[i + 1].x + 1))
    //    //    {
    //    //        var p = 0;
    //    //        while ((sortedList[i - 1].y == sortedList[i].y || sortedList[i - 1].y == (sortedList[i].y + 1) || sortedList[i - 1].y == (sortedList[i].y - 1)) && sortedList[i - 1].x == (sortedList[i].x - 1) && i < sortedList.Count - 1)
    //    //        {
    //    //            k = sortedList[i].x + k;
    //    //            l = sortedList[i].y + l;
    //    //            i++;
    //    //            p++;
    //    //        }
    //    //        Debug.Log("klskssk");
    //    //        k = k / p;
    //    //        l = l / p;

    //    //        //t2D1.SetPixel(k, l, Color.red);
    //    //        Debug.Log(k + "k" + "l" + l);
    //    //    }
    //    //}
    //    //for (int i = 0; i < differentColourPositions.Count; i++)
    //    //{
    //    //    //print(differentColourPositions[i]);
    //    //    //if(n < differentColourPositions[i].x)
    //    //    //{
    //    //    //    n = differentColourPositions[i - 1].x;
    //    //    //}
    //    //    //if(o < differentColourPositions[i].x)
    //    //    //{
    //    //    //    o = differentColourPositions[i - 1].y;
    //    //    //}
    //    //    n = differentColourPositions[i].x + n;
    //    //    o = differentColourPositions[i].y + o;
    //    //    //t2D1.SetPixel(differentColourPositions[i].x, differentColourPositions[i].y, Color.black);
    //    //}
    //    //print(n + "mm");
    //    //n = n / differentColourPositions.Count;
    //    //o = o / differentColourPositions.Count;
    //    //var m = differentColourPositions.Count / 2;
    //    //print(differentColourPositions[m]);
    //    ////t2D1.SetPixel(n, o, Color.black) ;
    //    //Debug.Log(differentColourPositions.Count);
    //    //for (var x = t2D.height; x > 0; x--)
    //    //{

    //    //}

    //    t2D1.Apply();

    //    for (int x = 0; x < t2D1.height; x++)
    //    {
    //        for (int y = 0; y < t2D1.width; y++)
    //        {
    //            Color px1 = t2D1.GetPixel(x, y);
    //            if (px1 == Color.black && !IsAlreadyExist(new Vector2Int(x, y)))
    //            {

    //                List<Vector2Int> l1 = AddFunctions(x, y);
    //                int sum = 0;
    //                int sum1 = 0;
    //                for (int j = 0; j < l1.Count; j++)
    //                {
    //                    print(l1[j]);
    //                    sum = l1[j].x + sum;
    //                    sum1 = l1[j].y + sum1;
    //                }
    //                t2D1.SetPixel(sum / l1.Count, sum1 / l1.Count, Color.red);
    //                l1.Clear();
    //                l2.Clear();
    //            }
    //        }
    //    }



    //    t2D1.Apply();
    //    //for (var x = 0; x < t2D.height; x++)
    //    //{
    //    //    var y = 0;
    //    //    bool isActive = true;
    //    //    //bool isCActive = false;
    //    //    //var xm = x;
    //    //    while (y < t2D.width)
    //    //    {
    //    //        Color px = t2D1.GetPixel(x, y);
    //    //        if (px == Color.red)
    //    //        {
    //    //            //Debug.Log("gg");
    //    //            //Debug.Log(y + "inside");

    //    //            t2D1.SetPixel(x, y, Color.red);
    //    //            Vector2Int c = new Vector2Int(x, y);
    //    //            while (isActive)
    //    //            {
    //    //                differentColourPositions.Add(new Vector2Int(x, y));
    //    //                Color px1 = t2D.GetPixel(x, y);
    //    //                if (px1 == Color.white && y < t2D.width)
    //    //                {
    //    //                    t2D1.SetPixel(x, y, Color.black);
    //    //                    isActive = false;

    //    //                }
    //    //                y++;
    //    //            }
    //    //        }
    //    //        y++;
    //    //    }

    //    //}
    //    //int miplevelx = 0;
    //    //t2D1.SetPixels(pixall, miplevelx);
    //    //t2D1.Apply();
    //    //Debug.Log("all pixels" + pixall.Length);
    //    //for(int x=0; x < t2D.height; x++)
    //    //{
    //    //    for(int y=0; y < t2D.width; y++)
    //    //    {
    //    //        Color pxx = t2D.GetPixel(x, y);
    //    //        if (pxx != Color.white)
    //    //        {

    //    //        }
    //    //    }
    //    //}
    //}
    //public List<Vector2Int> AddFunctions(int x, int y)
    //{
    //    if (t2D1.GetPixel(x + 1, y - 1) == Color.black)
    //    {
    //        l2.Add(new Vector2Int(x + 1, y - 1));
    //        sortedList2[y * width + x] = new Vector2Int(x + 1, y - 1));
    //        AddFunctions(x + 1, y - 1);

    //    }
    //    else if (t2D1.GetPixel(x + 1, y) == Color.black)
    //    {
    //        l2.Add(new Vector2Int(x + 1, y));
    //        sortedList2.Add(new Vector2Int(x + 1, y));
    //        AddFunctions(x + 1, y);

    //    }
    //    else if (t2D1.GetPixel(x + 1, y + 1) == Color.black)
    //    {
    //        l2.Add(new Vector2Int(x + 1, y + 1));
    //        sortedList2.Add(new Vector2Int(x + 1, y + 1));
    //        AddFunctions(x + 1, y + 1);

    //    }
    //    else
    //    {
    //        return l2;
    //    }
    //    return l2;
    //}
    //public bool IsAlreadyExist(Vector2Int pos)
    //{
    //    bool m = false;
    //    //for (int h = 0; h < sortedList2.Count; h++)
    //    {
    //        if (pos == sortedList2[pos.y * width + x])
    //        {
    //            m = true;
    //            break;
    //        }
    //    }
    //    return m;
    //}
    ////List<Vector2Int> indexesAlreadyChecked = new List<Vector2Int>();

    ////void CheckInNeighbour(Color[] tex, Vector2Int pos, int width,int height)
    ////{
    ////    if (tex[pos.x + pos.y * height + ] == Color.white)
    ////    {
    ////        return;
    ////    }
    ////    indexesAlreadyChecked.Add(pos + new Vector2Int(0, 1));

    ////}
}
