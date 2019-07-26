/****************************************************
    文件：StartMoveSystem.cs
	作者：CaptainYun
    日期：2019/7/25 18:31:42
	功能：响应鼠标事件，移动物体
*****************************************************/

using UnityEngine;
using Entitas;
using System.Collections.Generic;

namespace InterationExample {
    public class StartMoveSystem : ReactiveSystem<InputEntity> {
        private GameContext gameContext;
        private IGroup<GameEntity> moveGroup;

        public StartMoveSystem(Contexts contexts) : base(contexts.input) {
            gameContext = contexts.game;
            moveGroup = contexts.game.GetGroup(GameMatcher.InterationExampleView);
        }

        protected override void Execute(List<InputEntity> entities) {
            foreach (InputEntity inputEntity in entities) {
                Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                foreach (GameEntity gameEntity in moveGroup) {
                    gameEntity.ReplaceInterationExampleMove(worldPos);
                }
            }
        }

        protected override bool Filter(InputEntity entity) {
            return entity.hasInterationExampleMouse
                && entity.interationExampleMouse.mouse == MouseButton.RIGHT
                && entity.interationExampleMouse.MouseEvent == MouseButtonEvent.DOWN;
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context) {
            return context.CreateCollector(InputMatcher.InterationExampleMouse);
        }
    }
}