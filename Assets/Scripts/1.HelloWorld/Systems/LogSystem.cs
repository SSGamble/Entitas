/****************************************************
    文件：LogSystem.cs
	作者：CaptainYun
    日期：2019/7/25 9:57:3
	功能：打印消息系统
*****************************************************/

using UnityEngine;
using Entitas;
using System.Collections.Generic;

namespace HelloWorld {

    public class LogSystem : ReactiveSystem<GameEntity> { // GameEntity 是 Game 下的实体

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="context"></param>
        public LogSystem(Contexts contexts) : base(contexts.game) {

        }

        /// <summary>
        /// 筛选器，代表了当前系统的执行条件
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected override bool Filter(GameEntity entity) {
            return entity.hasHelloWorldLog; // 只有含有 LogCompontent 组件，才继续执行 Execute
        }

        /// <summary>
        /// 收集器，处理 Group 中 Entity 变化的反应
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
            return context.CreateCollector(GameMatcher.HelloWorldLog); // 创建一个收集器，传入一个匹配器（从 Context 中获取所感兴趣的 Groups）
        }

        /// <summary>
        /// 执行逻辑
        /// </summary>
        /// <param name="entities"></param>
        protected override void Execute(List<GameEntity> entities) {
            // 遍历传进来的实体并打印
            foreach (GameEntity entity in entities) {
                Debug.Log(entity.helloWorldLog.message);
            }
        }
    }
}