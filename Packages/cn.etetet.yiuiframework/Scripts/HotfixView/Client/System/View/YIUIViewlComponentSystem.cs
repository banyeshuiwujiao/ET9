﻿//------------------------------------------------------------
// Author: 亦亦
// Mail: 379338943@qq.com
// Data: 2023年2月12日
//------------------------------------------------------------

namespace ET.Client
{
    /// <summary>
    /// UI面板组件
    /// </summary>
    [FriendOf(typeof(YIUIViewComponent))]
    [EntitySystemOf(typeof(YIUIViewComponent))]
    public static partial class YIUIViewComponentSystem
    {
        [EntitySystem]
        private static void Awake(this YIUIViewComponent self)
        {
        }

        [EntitySystem]
        private static void YIUIInitialize(this YIUIViewComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this YIUIViewComponent self)
        {
        }
    }
}
