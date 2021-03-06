/********************************************************************************
** auth:  https://github.com/HushengStudent
** date:  2018/04/06 20:01:08
** desc:  状态机状态接口;
*********************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework
{
    public interface IFsmState
    {
        string Name { get; set; }
        IFsmMachine Parent { get; set; }
        float Time { get; set; }
        List<IFsmTransition> Transitions { get; set; }
        void OnEnter(IFsmState preState);
        void OnExit(IFsmState nextState);
        void OnUpdate();
        void OnLateUpdate();
        bool AddTransition(IFsmTransition trans);
        bool RemoveTransition(IFsmTransition trans);
        IFsmTransition GetTransition(IFsmTransition trans);
    }
}