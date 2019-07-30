/****************************************************
    文件：TestView.cs
	作者：CaptainYun
    日期：2019/7/30 10:29:24
	功能：Nothing
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestView : MonoBehaviour, IMultiReactiveNameListener {

    void Start() {

    }

    void Update() {

    }

    public void OnMultiReactiveName(GameEntity entity, string name) {
        throw new System.NotImplementedException();
    }
}
