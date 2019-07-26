/****************************************************
    文件：GameController.cs
	作者：CaptainYun
    日期：2019/7/25 10:34:11
	功能：利用 GameController 来进行框架的初始化及启动
*****************************************************/

using Entitas;
using UnityEngine;

namespace HelloWorld {

    public class GameController : MonoBehaviour {

        private Systems systems;

        private void Start() {
            var context = Contexts.sharedInstance; // 上下文对象
            systems = new Feature("Systems").Add(new AddGameSystems(context));
            systems.Initialize();
        }

        private void Update() {
            systems.Execute();
            systems.Cleanup();
        }
    }
}