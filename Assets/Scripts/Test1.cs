using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

/// <summary>
/// To方法实现动画
/// </summary>
public class Test1 : MonoBehaviour {

    public GameObject obj;//2D的ui设置为transform.localPosition
    public Image image;                    
    void Start () {
        #region
        DOTween.To(()=> obj.transform.position,x=> obj.transform.position = x,Vector3.zero,0.5f).SetLoops(3,LoopType.Yoyo);//3s内物体移动到Vector3.zero固定位置
        DOTween.To(() => image.color, x => image.color= x, Color.black, 1);//1s内image的颜色变成黑色

        #endregion
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
