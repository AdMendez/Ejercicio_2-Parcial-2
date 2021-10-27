using System;

namespace NivelAlcohol.Domain.Interfaces
{
    public interface IAmountAlcoholBlood
    {
        void TotalAlcoholConsumed(int amount, string drink);
        void AmountBlood();
        void MassEtanol();
        void VolumeBlood(int peso);
        void AlcoholBlood();
        string ReturnResult();
    }
}