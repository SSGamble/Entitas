/****************************************************
    文件：ViewComponent.cs
	作者：CaptainYun
    日期：2019/7/25 15:54:55
	功能：视图层组件
*****************************************************/

using UnityEngine;
using Entitas;

namespace InterationExample {

    public class ViewComponent : IComponent {
        /// <summary>
        /// 视图层对象
        /// </summary>
        public Transform viewTrans;
    }
}