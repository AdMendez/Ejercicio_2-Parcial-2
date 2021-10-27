using System;

namespace Resistencia.Domain.Interfaces
{
    public interface IOperationResistance
    {
        void FirstBand(string firstband);
        void SecondBand(string secondband);
        void Multiply(string thirdband);
        void Tolerance(string tolerance);
        string ReturnValue();
    }
}