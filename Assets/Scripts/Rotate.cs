using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	void Update () {
        gameObject.transform.Rotate(0, 30f * Time.deltaTime, 0);
	}
}
