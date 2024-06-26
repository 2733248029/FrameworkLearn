using System.Collections;
using System.Collections.Generic;
using FrameworkDesign;
using UnityEngine;
namespace CounterAPP
{
    public class CounterApp :Architecture<CounterApp>
    {

        protected override void Init()
        {
            RegisterSystem<ISystem>(new AchievementSystem());
            RegisterUtility<IStorage>(new PlayerPrefsStorage());
            RegisterModel<ICounterModel>(new CounterModel());
        }
    }
}

