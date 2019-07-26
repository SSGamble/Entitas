/****************************************************
    文件：SpriteComponent.cs
	作者：CaptainYun
    日期：2019/7/25 16:13:54
	功能：图片组件
*****************************************************/

using UnityEngine;
using Entitas;
namespace InterationExample {

    [Game]
    public class SpriteComponent : IComponent {
        /// <summary>
        /// 图片名字
        /// </summary>
        public string spriteName;
    }
}