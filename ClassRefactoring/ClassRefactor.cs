using System;

// developer selvan seeman
// 02/26/2023
namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public enum Speed
    {
        None = 0,
        AfricanSwallowSpeed = 22,
        LadenAfricanSwallowSpeed = 18,
        EuropeanSwallowSpeed = 20,
        LadenEuropeanSwallowSpeed = 16
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType) => new Swallow(swallowType);
    }

    public class Swallow
    {
        private SwallowType Type { get; }
        private SwallowLoad Load { get; set; }

        public Swallow(SwallowType swallowType)
        {
            Type = swallowType;
        }

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public Speed GetAirspeedVelocity()
        {
            Speed speed = Speed.None;

            if (Type == SwallowType.African && Load == SwallowLoad.None)
            {
                speed = Speed.AfricanSwallowSpeed;
            }
            else if (Type == SwallowType.African && Load == SwallowLoad.Coconut)
            {
                speed = Speed.LadenAfricanSwallowSpeed;
            }
            else if (Type == SwallowType.European && Load == SwallowLoad.None)
            {
                speed = Speed.EuropeanSwallowSpeed;
            }
            else if (Type == SwallowType.European && Load == SwallowLoad.Coconut)
            {
                speed = Speed.LadenEuropeanSwallowSpeed;
            }
            else
            {
                throw new InvalidOperationException();
            }

            return speed;
        }
    }
}