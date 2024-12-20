using System.Diagnostics;
using System;
using System.Collections;

namespace LiveCoding
{
    class sortThing : IComparer<float>{
        public int Compare(float x, float y){
            return x.CompareTo(y);
        }
    }


    public class Rational : {
        float _numerator;
        float _denominator;

        public Rational(int numerator, int denominator)
        {
            _numerator = numerator;
            if (denominator == 0)
            {
                throw new ArgumentException(String.Format($"{denominator} is not a valid demoninator value."));
            }
            _denominator = denominator;
        }

        public float ToDecimal(){
            return _numerator/_denominator;
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
    }
}