/****************************************************
    文件：GameController.cs
	作者：CaptainYun
    日期：2019/7/25 16:27:33
	功能：利用 GameController 来进行框架的初始化及启动
*****************************************************/

using UnityEngine;
using Entitas;

namespace InterationExample {

    public class GameController : MonoBehaviour {

        private Systems systems;
        private Contexts contexts;

        private void Start() {
            contexts = Contexts.sharedInstance; // 上下文对象
            systems = CreateSystems(contexts);
            //systems.Initialize();
        }

        private void Update() {
            systems.Execute();
            systems.Cleanup();
        }

        private Systems CreateSystems(Contexts contexts) {
            return new Feature("System")
                .Add(new GameFeature(contexts))
                .Add(new InputFeature(contexts));
        }
    }
}