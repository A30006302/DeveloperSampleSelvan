using Xunit;

// developer selvan seeman
// 02/26/2023
namespace DeveloperSample.Container
{
    internal interface IContainerTestInterface
    {
    }

    internal class ContainerTestClass : IContainerTestInterface
    {
    }

    public class ContainerTest
    {
        [Fact]
        public void CanBindAndGetService()
        {
            ContainerTestClass containerTestClassObject = new ContainerTestClass();
            var container = new Container();
            container.Bind<ContainerTestClass>(typeof(IContainerTestInterface), containerTestClassObject);
            var testInstance = container.Get<IContainerTestInterface>();
            Assert.IsType<ContainerTestClass>(testInstance);
        }
    }
}