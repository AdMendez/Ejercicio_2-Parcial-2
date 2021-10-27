using System;
using NivelAlcohol.Domain.Interfaces;

namespace NivelAlcohol.Domain.Entities
{
    public class AmountAlcoholBlood : IAmountAlcoholBlood
    {
        private int _amount = 0;
        private string _drink = "";
        private double _operation = 0;
        private int _peso = 0;
        private double _volumen = 0;
        private double _result = 0;


        public void TotalAlcoholConsumed(int amount, string drink)
        {
            _amount = amount;
            _drink = drink;
            _drink = _drink.ToLower();

            if(_drink == "cerveza")
            {
                var ml = 330;
                _amount = _amount * ml;
                var graduation = 5;
                _amount = (graduation/100)*(_amount);
            }

            if(_drink == "vino" || _drink == "cava")
            {
                var ml = 100;
                _amount = _amount * ml;
                var graduation = 12;
                _amount = (graduation/100)*(_amount);
            }

            if(_drink == "vermú")
            {
                var ml = 70;
                _amount = _amount * ml;
                var graduation = 17;
                _amount = (graduation/100)*(_amount);
            }

            if(_drink == "licor")
            {
                var ml = 45;
                _amount = _amount * ml;
                var graduation = 23;
                _amount = (graduation/100)*(_amount);
            }

            if(_drink == "brandy")
            {
                var ml = 45;
                _amount = _amount * ml;
                var graduation = 38;
                _amount = (graduation/100)*(_amount);
            }

            if(_drink == "combinado")
            {
                var ml = 50;
                _amount = _amount * ml;
                var graduation = 38;
                _amount = (graduation/100)*(_amount);
            }

        }
    
        public void AmountBlood()
        {
            _amount = (15/100) * (_amount);
        }
    
        public void MassEtanol()
        {
            var etanol = 0.789;
            _operation = etanol * _amount;
        }
    
        public void VolumeBlood(int peso)
        {
            _peso = peso;
            _volumen = (8/100) * _peso;
        }

        public void AlcoholBlood()
        {
            _result = _operation / _volumen;
        }
    
        public string ReturnResult()
        {
            return $"Su cantidad de alcohol en es {_result}, es superior a 0.8 g/L, por lo tanto no puede manejar, solicite apoyo";
        }
    }
}