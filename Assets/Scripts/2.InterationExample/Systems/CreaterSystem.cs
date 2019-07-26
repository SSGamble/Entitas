/****************************************************
    文件：CreaterSystem.cs
	作者：CaptainYun
    日期：2019/7/25 16:54:40
	功能：创建实体系统
*****************************************************/

using UnityEngine;
using Entitas;
using System.Collections.Generic;

namespace InterationExample {
    public class CreaterSystem : ReactiveSystem<InputEntity> {

        private GameContext gameContext;

        public CreaterSystem(Contexts contexts) : base(contexts.input) {
            gameContext = contexts.game;
        }

        protected override bool Filter(InputEntity entity) {
            return entity.hasInterationExampleMouse
                && entity.interationExampleMouse.mouse == MouseButton.LEFT
                && entity.interationExampleMouse.MouseEvent == MouseButtonEvent.DOWN;
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context) {
            return context.CreateCollector(InputMatcher.InterationExampleMouse);
        }

        protected override void Execute(List<InputEntity> entities) {
            foreach (InputEntity entity in entities) {
                GameEntity gameEntity = gameContext.CreateEntity();
                gameEntity.AddInterationExampleSprite("Bullet");
                Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // 是根据 Tag 来获取的
                gameEntity.AddInterationExamplePosition(worldPos);
            }
        }
    }
}