using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScreenCap: MonoBehaviour
{
    Texture2D screenCap;
   // Texture2D border;
    bool shot = false;

    // Use this for initialization
    void Start()
    {
        screenCap = new Texture2D(300, 200, TextureFormat.RGB24, false); // 1
       // border = new Texture2D(2, 2, TextureFormat.ARGB32, false); // 2
       // border.Apply();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { // 3
            StartCoroutine("Capture");
            //Capture();
        }
    }

    void OnGUI()
    {
        /*
        GUI.DrawTexture(new Rect(200, 100, 300, 2), border, ScaleMode.StretchToFill); // top
        GUI.DrawTexture(new Rect(200, 300, 300, 2), border, ScaleMode.StretchToFill); // bottom
        GUI.DrawTexture(new Rect(200, 100, 2, 200), border, ScaleMode.StretchToFill); // left
        GUI.DrawTexture(new Rect(500, 100, 2, 200), border, ScaleMode.StretchToFill); // right
*/
        if (shot)
        {
            GUI.DrawTexture(new Rect(10, 10, 60, 40), screenCap, ScaleMode.StretchToFill);
        }
    }

    IEnumerator Capture()
    {
        yield return new WaitForEndOfFrame();
        screenCap.ReadPixels(new Rect(500, 500, 500, 500), 0, 0);
        screenCap.Apply();
        shot = true;
    }
}