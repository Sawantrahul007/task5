using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecursiveWay2 : MonoBehaviour
{
    Texture2D t2D;
    Texture2D t2D1;
    public GameObject tx;
    private RawImage rawimage2;
    //private Color j;
    //private float t = 0;

    //Vector2Int[] sortedList2 = new Vector2Int[640*640];
    //bool[] sortedList2Tracker = new bool[640*640];
    List<Vector2Int> sortedList2 = new List<Vector2Int>();
    List<Vector2Int> l2 = new List<Vector2Int>();
    Vector2Int[] direction = {new Vector2Int(1,1), new Vector2Int(1, -1), new Vector2Int(1, 0), new Vector2Int(0, 1), new Vector2Int(0, -1), new Vector2Int(-1, 1), new Vector2Int(-1, -1), new Vector2Int(-1, 0)};
    void Start()
    {

        var rawImage = GetComponent<RawImage>();
        rawimage2 = tx.GetComponent<RawImage>();
        t2D = rawImage.texture as Texture2D;
        //sortedList2 = new Vector2Int[t2D.width*t2D.height];
        t2D1 = rawimage2.texture as Texture2D;
        for (var x = 0; x < t2D.height; x++)
        {
            var y = 0;
            // bool isActive = true;
            while (y < t2D.width)
            {
                // Color px = t2D.GetPixel(x, y);
                t2D1.SetPixel(x, y, Color.white);
                y++;
            }
        }
        //var newlistx = new List<Color>();
        //List<Vector2Int> differentCo = new List<Vector2Int>();
        //List<Vector2Int> differentColourPositions = new List<Vector2Int>();
        //List<Vector2Int> sortedList = new List<Vector2Int>();

        //for (var x = 0; x < t2D.height; x++)
        //{
        //    var y = 0;

        //    //bool isCActive = false;
        //    var xm = x;
        //    while (y < t2D.width)
        //    {
        //        bool isActive = true;
        //        Color px = t2D.GetPixel(x, y);
        //        if (px != Color.white)
        //        {
        //            differentCo.Add(new Vector2Int(x, y));
        //            //Debug.Log(t2D.GetPixel(x, y));
        //            if (t == 0)
        //            {
        //                j = t2D.GetPixel(x, y);
        //                differentColourPositions.Add(new Vector2Int(x, y));
        //            }
        //            t++;
        //            t2D1.SetPixel(x, y, Color.red);
        //            // Vector2Int c = new Vector2Int(x,y);
        //            while (isActive)
        //            {
        //                if (j == t2D.GetPixel(x, y))
        //                {
        //                    differentColourPositions.Add(new Vector2Int(x, y));
        //                }
        //                //differentColourPositions.Add(new Vector2Int(x, y));
        //                Color px1 = t2D.GetPixel(x, y);
        //                if (px1 == Color.white && y < t2D.width)
        //                {
        //                    t2D1.SetPixel(x, y, Color.red);
        //                    isActive = false;

        //                }
        //                y++;
        //            }
        //            differentCo.Add(new Vector2Int(x, y));
        //            var f = (differentCo[0].x + differentCo[1].x) / 2;
        //            var g = (differentCo[0].y + differentCo[1].y) / 2;
        //            sortedList.Add(new Vector2Int(f, g));
        //            t2D1.SetPixel(f, g, Color.black);
        //            differentCo.Clear();
        //        }
        //        y++;
        //    }
        //}

        t2D1.Apply();
        int i = 0;
        for (int x = 0; x < t2D.height; x++)
        {
            for (int y = 0; y < t2D.width; y++)
            {
                Color px1 = t2D.GetPixel(x, y);
                if (px1 != Color.white && !IsAlreadyExist(new Vector2Int(x, y))&& i==0)
                {
                    i++;
                    List<Vector2Int> l1 = AddFunctions(x, y);
                    int sum = 0;
                    int sum1 = 0;
                    for (int j = 0; j < l1.Count; j++)
                    {
                        t2D1.SetPixel(l1[j].x,l1[j].y,Color.black);
                        sum = l1[j].x + sum;
                        sum1 = l1[j].y + sum1;
                    }
                    
                    t2D1.SetPixel(sum / l1.Count, sum1 / l1.Count, Color.red);
                    break;

                    //l1.Clear();
                    //l2.Clear();
                }
            }
        }
        t2D1.Apply();
    }
    public List<Vector2Int> AddFunctions(int x, int y)
    {
        //if (t2D.GetPixel(x, y) == Color.white && IsAlreadyExist(new Vector2Int(x, y)))
        //{
        //    return l2;
        //}
        
        for (int i = 0; i < direction.Length; i++)
        {
            if (t2D.GetPixel(x + direction[i].x, y + direction[i].y) == Color.white || IsAlreadyExist(new Vector2Int(x + direction[i].x, y + direction[i].y)))
            {
                return l2;
            }
            else
            {
                l2.Add(new Vector2Int(x + direction[i].x, y + direction[i].y));
                sortedList2.Add(new Vector2Int(x + direction[i].x, y + direction[i].y));
                AddFunctions(x + direction[i].x, y + direction[i].y);
            }
            
            //else
            //{
            //    return l2;
            //}
        }
        return l2;
        //if (t2D1.GetPixel(x + 1, y - 1) == Color.black)
        //{
        //    l2.Add(new Vector2Int(x + 1, y - 1));
        //    sortedList2.Add(new Vector2Int(x + 1, y - 1));
        //    AddFunctions(x + 1, y - 1);

        //}
        //else if (t2D1.GetPixel(x + 1, y) == Color.black)
        //{
        //    l2.Add(new Vector2Int(x + 1, y));
        //    sortedList2.Add(new Vector2Int(x + 1, y));
        //    AddFunctions(x + 1, y);

        //}
        //else if (t2D1.GetPixel(x + 1, y + 1) == Color.black)
        //{
        //    l2.Add(new Vector2Int(x + 1, y + 1));
        //    sortedList2.Add(new Vector2Int(x + 1, y + 1));
        //    AddFunctions(x + 1, y + 1);

        //}
        //else
        //{
        //    return l2;
        //}
        //return l2;
    }
    public bool IsAlreadyExist(Vector2Int pos)
    {
        bool m = false;
        for (int h = 0; h < sortedList2.Count; h++)
        {
            if (pos == sortedList2[h])
            {
                m = true;
                break;
            }
        }
        return m;
    }
    //List<Vector2Int> indexesAlreadyChecked = new List<Vector2Int>();

    //void CheckInNeighbour(Color[] tex, Vector2Int pos, int width,int height)
    //{
    //    if (tex[pos.x + pos.y * height + ] == Color.white)
    //    {
    //        return;
    //    }
    //    indexesAlreadyChecked.Add(pos + new Vector2Int(0, 1));

    //}
}
