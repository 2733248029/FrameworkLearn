using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FrameworkDesign
{
    public interface IModel : IBelongToArchitecture,ICanSetArchitecture,ICanGetUtility,ICanSendEvent
    {
        void Init();
    }
    public abstract class AbstractModel:IModel
    {
        private IArchitecture mArchitecture = null;
        IArchitecture  IBelongToArchitecture.GetArchitecture() 
        {
            return mArchitecture;
        }
        void IModel.Init()
        {
            OnInit();
        }
        protected abstract void OnInit();

         void ICanSetArchitecture.SetArchitecture(IArchitecture architecture)
        {
            mArchitecture = architecture;
        }
    }
}

