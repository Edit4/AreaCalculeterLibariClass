using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculetor.Interface
{
    /// <summary>
    /// Интерфейс для геометрических фигур
    /// </summary
    interface IGeometricShape
    {
        /// <summary>
        /// Вычисление площади геометрической фигуры
        /// </summary>
        /// <returns>Площадь в квадратичных единицах</returns>
        public double GetArea();
    }
}
