using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class Test3 : MonoBehaviour {
    
    public Transform _image;
    Button btn;
    bool isshow =false;
    // Use this for initialization
    void Start()
    {
        btn = GameObject.Find("Canvas").transform.FindChild("Button").GetComponent<Button>();
        btn.onClick.AddListener(Btnclick);
        Tweener tweener= _image.DOLocalMove(Vector3.zero, 2f);
        tweener.SetAutoKill(false);
        _image.DOPause();
        print(isshow);
        Invoke("kill", 10f);
    }

   
    /// <summary>
    /// 按钮点击
    /// </summary>
    private void Btnclick()
    {
        if (!isshow)
        {
            _image.DOPlayForward();
            //_image.DOPlay();//只能播放以一次
        }
        else
        {
            _image.DOPlayBackwards();
        }
        isshow = !isshow;

    }
    void kill()
    {
        _image.DOKill();//销毁动画
    }
}
