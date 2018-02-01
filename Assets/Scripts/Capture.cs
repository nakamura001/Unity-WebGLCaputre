using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Capture : MonoBehaviour {

    [DllImport("__Internal")]
    private static extern void CanvasCapture(byte[] img, int size);
	
	public void Execute () {
        StartCoroutine(_Execute());
	}

    IEnumerator _Execute()
    {
        yield return new WaitForEndOfFrame();
        Texture2D tex = new Texture2D(Screen.width, Screen.height);
        tex.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        tex.Apply();
        byte[] img = tex.EncodeToPNG();
        CanvasCapture(img, img.Length);
    }
}
