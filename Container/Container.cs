using System;
using System.Diagnostics;

// developer selvan seeman
// 02/26/2023
namespace DeveloperSample.Container
{
    public class Container
    {
        private object containerTestClass;
        public void Bind<T>(Type interfaceType, T implementationType) => containerTestClass = implementationType;
        public object Get<T>() => containerTestClass; 
    }
}