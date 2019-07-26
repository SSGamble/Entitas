/****************************************************
    文件：MouseComponent.cs
	作者：CaptainYun
    日期：2019/7/25 15:40:30
	功能：鼠标点击组件
*****************************************************/

using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace InterationExample {
    [Input,Unique] // Unique 该组件全局唯一
    public class MouseComponent : IComponent {

        /// <summary>
        /// 点击的鼠标类型
        /// </summary>
        public MouseButton mouse;

        /// <summary>
        /// 鼠标事件
        /// </summary>
        public MouseButtonEvent MouseEvent;
    }
}