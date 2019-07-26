/****************************************************
    文件：AddGameSystems.cs
	作者：CaptainYun
    日期：2019/7/25 10:28:43
	功能：添加系统到框架内
*****************************************************/

namespace HelloWorld {
    public class AddGameSystems : Feature {
        public AddGameSystems(Contexts contexts) : base("AddGameSystems") {
            Add(new LogSystem(contexts));
            Add(new InitSystem(contexts));
        }
    }
}