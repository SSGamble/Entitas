/****************************************************
    文件：MouseSystem.cs
	作者：CaptainYun
    日期：2019/7/25 16:34:24
	功能：鼠标事件响应系统
*****************************************************/

using UnityEngine;
using Entitas;

namespace InterationExample {
    public class MouseSystem : IExecuteSystem, IInitializeSystem {

        private InputEntity inputEntity;
        private InputContext context;

        public MouseSystem(Contexts contexts) {
            context = contexts.input;
        }

        public void Initialize() {
            inputEntity = context.interationExampleMouseEntity;
        }

        public void Execute() {
            if (Input.GetMouseButtonDown(0)) {
                context.ReplaceInterationExampleMouse(MouseButton.LEFT, MouseButtonEvent.DOWN); // 更新数据
            }
            if (Input.GetMouseButtonDown(1)) {
                context.ReplaceInterationExampleMouse(MouseButton.RIGHT, MouseButtonEvent.DOWN); // 更新数据
            }
        }
    }
}