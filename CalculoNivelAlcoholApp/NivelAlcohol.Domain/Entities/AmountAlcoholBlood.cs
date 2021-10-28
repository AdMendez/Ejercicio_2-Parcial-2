using System;
using NivelAlcohol.Domain.Interfaces;

namespace NivelAlcohol.Domain.Entities
{
    public class AmountAlcoholBlood : IAmountAlcoholBlood
    {
        private int _amount = 0;
        private string _drink = "";
        private int ml = 0;
        private double graduation = 0.0;
        private double _total;
        private double _fact;
        private double _etanol = 0.789;
        private double _operation;
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
                ml = 330;
                _amount = _amount * ml;
                graduation = 5;
                _total = (graduation/100)*(_amount);
            }

            if(_drink == "vino" || _drink == "cava")
            {
                ml = 100;
                _amount = _amount * ml;
                graduation = 12;
                _total = (graduation/100)*(_amount);
            }

            if(_drink == "vermú")
            {
                ml = 70;
                _amount = _amount * ml;
                graduation = 17;
                _total = (graduation/100)*(_amount);
            }

            if(_drink == "licor")
            {
                ml = 45;
                _amount = _amount * ml;
                graduation = 23;
                _total = (graduation/100)*(_amount);
            }

            if(_drink == "brandy")
            {
                ml = 45;
                _amount = _amount * ml;
                graduation = 38;
                _total = (graduation/100)*(_amount);
            }

            if(_drink == "combinado")
            {
                ml = 50;
                _amount = _amount * ml;
                graduation = 38;
                _total = (graduation/100)*(_amount);
            }


        }
    
        public void AmountBlood()
        {
            _fact = 0.15 * _total;
        }
    
        public void MassEtanol()
        {
            _operation = _etanol * _fact;
        }
    
        public void VolumeBlood(int peso)
        {
            _peso = peso;
            _volumen = 0.08 * _peso;
        }

        public void AlcoholBlood()
        {
            _result = _operation / _volumen;
        }
    
        public string ReturnResult()
        {
            if(_result < 0.8)
            {
                return $"Su cantidad de alcohol en sangre es {_result} g/L, no es superior a 0.8 g/L, tenga un buen viaje...";
            }
            return $"Su cantidad de alcohol en sangre es {_result} g/L, es superior a 0.8 g/L, por lo tanto no puede manejar, solicite apoyo";
        }
    }
}