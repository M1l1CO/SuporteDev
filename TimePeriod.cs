using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuporteDev
{
    public class TimePeriod
    {
        private double _seconds;
        public double Hours
        {
            get { return _seconds / 3600; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        "The valid range is between 0 and 24.");
                }
                
                _seconds = value * 3600; 
            }
        }

        public TimePeriod(int horas)
        {
            _seconds = horas;
        }

        // Método de acesso (getter) para ler a propriedade privada
        public double GetMinhaPropriedadePrivada()
        {
            return _seconds;
        }

    }
}