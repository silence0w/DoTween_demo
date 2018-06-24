using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
/// <summary>
/// 屏幕振动
/// </summary>
public class test4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.DOShakePosition(2, new Vector3(10, 0, 0));//屏幕物体震动向周围
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
