using Negocio.business.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.business.rules.generic
{
    public class MaxLengthRule
    {
        public void isValid(string nameElement, string value, int maxSize)
        {
            if (value.Length > maxSize) {
                throw new BusinessException("El campo " + nameElement +
                    " debe poseer mas de " + maxSize + " caracteres");
            }
        }
    }
}
