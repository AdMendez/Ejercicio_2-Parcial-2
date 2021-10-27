using System;

namespace NivelAlcohol.Domain.Entities
{
    public class AmountAlcoholBlood
    {
        private int _amount = 0;
        private string _drink = "";


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
    
    
    }
}