/****************************************************
    文件：InpputController.cs
	作者：CaptainYun
    日期：2019/7/30 10:28:19
	功能：Nothing
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InpputController : MonoBehaviour {

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Contexts.sharedInstance.game.CreateEntity().isMultiReactiveDestroyed = true;
            //Contexts.sharedInstance.input.CreateEntity().isMultiReactiveDestroyed = true;
        }
    }
}
