/****************************************************
    文件：PositionComponent.cs
	作者：CaptainYun
    日期：2019/7/25 15:32:26
	功能：坐标组件，组件最好不要使用 unity 的东西，这里只是为了演示的方便
*****************************************************/

using UnityEngine;
using Entitas;

namespace InterationExample {
    [Game]
    public class PositionComponent : IComponent {
        public Vector2 position;
    }

}