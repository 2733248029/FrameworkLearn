using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FrameworkDesign
{
    public interface ICanSendCommand : IBelongToArchitecture
    {


    }
    public static class ICanSendCommandExtension
    {
        public static void SendCommand<T>(this ICanSendCommand self) where T : ICommand,new()
        {
            self.GetArchitecture().SendCommand<T>();
        }
        public static void SendCommand<T>(this ICanSendCommand self,T command)where T :ICommand
        {
             self.GetArchitecture().SendCommand<T>(command);  
        }
    }
}

