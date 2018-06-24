using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// DOLocalMove方法实现移动  还有其它方法DOFade DOcolor等 自行研究
/// </summary>
public class Test2 : MonoBehaviour {
   public Transform _text;
    public Text text;
    public Transform _image;
    Button btn;
	// Use this for initialization
	void Start () {
        btn =GameObject.Find("Canvas").transform.FindChild("Button").GetComponent<Button>();
        btn.onClick.AddListener(Btnclick);
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    /// <summary>
    /// 按钮点击
    /// </summary>
    private void Btnclick()
    {
        _text.DOLocalMove(new Vector3(-1657,-370,0),15f).SetLoops(-1);
        _image.DOLocalMove(Vector3.zero, 2f).SetLoops(-1, LoopType.Restart);
        text.DOText("113132132321356546546546",1);//文字显示动画

    }
}
