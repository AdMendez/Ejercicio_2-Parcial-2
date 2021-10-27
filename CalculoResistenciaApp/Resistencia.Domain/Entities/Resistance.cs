using System;
using Resistencia.Domain.Interfaces;

namespace Resistencia.Domain.Entities
{
    public class Resistance : IOperationResistance
    {
        private string _firstband;
        private string _secondband;
        private string _thirdband;
        private string _tolerance;
        private string  _firstvalue;
        private string  _secondvalue;
        private string _result;
        private int _multiply = 0;
        private double _resultT = 0; 
        

        public void FirstBand(string firstBand)
        {
            _firstband = firstBand;
            _firstband = _firstband.ToLower();
            _firstvalue = "";
            if(_firstband == "negro")
            {
                _firstvalue = "0";
            }
            
            if(_firstband == "cafe")
            {
                _firstvalue = "1";
            }

            if(_firstband == "rojo")
            {
                _firstvalue = "2";
            }

            if(_firstband == "naranja")
            {
                _firstvalue = "3";
            }

            if(_firstband == "amarillo")
            {
                _firstvalue = "4";
            }

            if(_firstband == "verde")
            {
                _firstvalue = "5";
            }

            if(_firstband == "azul")
            {
                _firstvalue = "6";
            }
            

            if(_firstband == "violeta")
            {
                _firstvalue = "7";
            }

            if(_firstband == "gris")
            {
                _firstvalue = "8";
            }

            if(_firstband == "blanco")
            {
                _firstvalue = "9";
            }
            
            if(_firstvalue == "")
            {
                //_error = "El color que proporciono en la PRIMERA BANDA no es valido. Intente de nuevo...";
            }
        }

        public void SecondBand(string secondBand)
        {
            _secondband = secondBand;
            _secondband = _secondband.ToLower();
            _secondvalue = "";

            if(_secondband == "negro")
            {
                _secondvalue = "0";
                _result = _firstvalue + _secondvalue;
            }
            
            if(_secondband == "cafe")
            {
                _secondvalue = "1";
                _result = _firstvalue + _secondvalue;
            }

            if(_secondband == "rojo")
            {
                _secondvalue = "2";
                _result = _firstvalue + _secondvalue;
            }

            if(_secondband == "naranja")
            {
                _secondvalue = "3";
                _result = _firstvalue + _secondvalue;
            }

            if(_secondband == "amarillo")
            {
                _secondvalue = "4";
                _result = _firstvalue + _secondvalue;
            }

            if(_secondband == "verde")
            {
                _secondvalue = "5";
                _result = _firstvalue + _secondvalue;
            }

            if(_secondband == "azul")
            {
                _secondvalue = "6";
                _result = _firstvalue + _secondvalue;
            }
            

            if(_secondband == "violeta")
            {
                _secondvalue = "7";
                _result = _firstvalue + _secondvalue;
            }

            if(_secondband == "gris")
            {
                _secondvalue = "8";
                _result = _firstvalue + _secondvalue;
            }

            if(_secondband == "blanco")
            {
                _secondvalue = "9";
                _result = _firstvalue + _secondvalue;
            }

            if (_secondvalue == "")
            {
                _result = "0";
                //_error = "El color que proporciono en la SEGUNDA BANDA no es valido. Intente de nuevo...";
            }
        }
    
        public void Multiply(string thirdBand)
        {
            _thirdband = thirdBand;
            _thirdband = _thirdband.ToLower();
            _multiply = 0;

            if (_thirdband == "negro")
            {
                _multiply = 1;
                _multiply = int.Parse(_result) * _multiply;
            }

            if (_thirdband == "cafe")
            {
                _multiply = 10;
                _multiply = int.Parse(_result) * _multiply;
            }

            if (_thirdband == "rojo")
            {
                _multiply = 100;
                _multiply = int.Parse(_result) * _multiply;
            }

            if (_thirdband == "naranja")
            {
                _multiply = 1000;
                _multiply = int.Parse(_result) * _multiply;
            }

            if (_thirdband == "amarillo")
            {
                _multiply = 10000;
                _multiply = int.Parse(_result) * _multiply;
            }

            if (_thirdband == "verde")
            {
                _multiply = 100000;
                _multiply = int.Parse(_result) * _multiply;
            }

            if (_thirdband == "azul")
            {
                _multiply = 1000000;
                _multiply = int.Parse(_result) * _multiply;
            }

            if(_thirdband == "dorado")
            {
                _multiply = 10;
                _multiply = int.Parse(_result) / _multiply; 
            }

            if(_thirdband == "plata")
            {
                _multiply = 100;
                _multiply = int.Parse(_result) / _multiply;
            }
            
            if(_multiply == 0)
            {
                //_error = "El color que proporciono en la TERCERA BANDA no es valido. Intente de nuevo..";
            }

            if(_result == "0")
            {
                //_error = "El color que proporciono en la TERCERA BANDA no es valido. Intente de nuevo..";
            }
      
        }
    
        public void Tolerance(string tolerance)
        {
            _tolerance = tolerance;
            _tolerance = _tolerance.ToLower();
            
            if(_tolerance == "dorado")
            {
                _resultT = _multiply * 0.05;
            }

            if(_tolerance == "plata")
            {
                _resultT = _multiply * 0.10;
            }

            if(_resultT == 0)
            {
                //_error = "El color que proporciono en la TOLERANCIA no es valido. Intente de nuevo..";
            }
            
        } 

        public string ReturnValue()
        {
            if (_firstvalue == "")
            {
                return "El color que proporciono en la PRIMERA BANDA no es valido. Intente de nuevo...";
            }
            if (_secondvalue == "")
            {
                return "El color que proporciono en la SEGUNDA BANDA no es valido. Intente de nuevo...";
            }
            if(_multiply == 0)
            {
                return "El color que proporciono en la TERCERA BANDA no es valido. Intente de nuevo...";
            }
            if(_resultT == 0)
            {
                return "El color que proporciono en la TOLERANCIA no es valido. Intente de nuevo...";
            }

            return $"El valor de la resistencia es {_multiply} Ω, la tolerancia es {_resultT} Ω más o menos.";
        }
    }
    
}