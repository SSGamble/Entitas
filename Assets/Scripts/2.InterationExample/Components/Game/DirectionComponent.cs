/****************************************************
    文件：DirectionComponent.cs
	作者：CaptainYun
    日期：2019/7/25 15:38:39
	功能：方向组件
*****************************************************/

using UnityEngine;
using Entitas;

namespace InterationExample {
    [Game]
    public class DirectionComponent : IComponent {
        /// <summary>
        /// 方向
        /// </summary>
        public float direction;
    }
}
