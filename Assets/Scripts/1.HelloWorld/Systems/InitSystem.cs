/****************************************************
    文件：InitSystem.cs
	作者：CaptainYun
    日期：2019/7/25 10:22:48
	功能：初始化系统
*****************************************************/

using Entitas;

namespace HelloWorld {
    public class InitSystem : IInitializeSystem {

        private readonly GameContext gameContext; // 上下文

        public InitSystem(Contexts contexts) {
            gameContext = contexts.game;
        }

        public void Initialize() {
            gameContext.CreateEntity().AddHelloWorldLog("Hello World! -- Entitas");
        }
    }
}