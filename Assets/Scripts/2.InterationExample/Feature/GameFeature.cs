/****************************************************
    文件：GameFeature.cs
	作者：CaptainYun
    日期：2019/7/25 16:24:57
	功能：添加系统到框架内
*****************************************************/

using UnityEngine;
using Entitas;

namespace InterationExample {
    public class GameFeature : Feature {
        public GameFeature(Contexts contexts) {
            Add(new AddViewSystem(contexts));
            Add(new RenderSpriteSystem(contexts));
            Add(new PositionSystem(contexts));
            Add(new MoveSystem(contexts));
            Add(new DirectionSystem(contexts));
            Add(new ChangeRotationSystem(contexts));
        }
    }
}