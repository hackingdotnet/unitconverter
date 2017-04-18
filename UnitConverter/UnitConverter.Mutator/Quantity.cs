using System;

namespace UnitConverter.Mutator
{
    public abstract class Quantity<TAmount, TUnit> : IComparable, IComparable<Quantity<TAmount, TUnit>>,
        IEquatable<Quantity<TAmount, TUnit>>
        where TAmount : struct, IComparable
    {
        /// <summary>
        /// Gets the amount
        /// </summary>
        public TAmount Amount { get; }

        /// <summary>
        /// Gets the unit
        /// </summary>
        public TUnit Unit { get; }

        /// <summary>
        /// Initializes a new Quantity with a specified amount and unit
        /// </summary>
        /// <param name="amount">The amount</param>
        /// <param name="unit">The unit</param>
        /// <exception cref="ArgumentNullException">unit is null</exception>
        protected Quantity(TAmount amount, TUnit unit)
        {
            if (unit == null)
            {
                throw new ArgumentNullException(nameof(unit));
            }
            
            this.Amount = amount;
            this.Unit = unit;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Quantity<TAmount, TUnit> other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Quantity<TAmount, TUnit> other)
        {
            throw new NotImplementedException();
        }
    }
}
