/****************************************************
    文件：MoveComponent.cs
	作者：CaptainYun
    日期：2019/7/25 18:18:15
	功能：移动组件
*****************************************************/

using UnityEngine;
using Entitas;

namespace InterationExample {
    public class MoveComponent : IComponent {
        /// <summary>
        /// 目标位置
        /// </summary>
        public Vector3 targetPos;
    }
}