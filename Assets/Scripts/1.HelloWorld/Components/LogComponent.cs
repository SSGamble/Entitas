/****************************************************
    文件：LogCompontent.cs
	作者：CaptainYun
    日期：2019/7/25 9:39:48
	功能：打印消息组件
*****************************************************/

using Entitas;

namespace HelloWorld {
    /// <summary>
    /// Entity 是一个数据的容器，代表游戏中某个对象，它应该只有数据，没有方法，你可以以组件形式（IComponent）添加、替代、删除这些数据。
    /// </summary>
    [Game] // 特性标签
    public class LogComponent : IComponent { // 组件需要继承 IComponent 接口

        /// <summary>
        /// 打印的消息
        /// </summary>
        public string message;
    }
}

