using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_lab2
{
    class Item(int value, int weight)
    {
        private int Value { get; set; } = value;
        private int Weight { get; set; } = weight;

        public override string ToString()
        {
            return $"Value: {Value}, Weight: {Weight}";
        }

        public int GetValue() => Value;
        public int GetWeight() => Weight;
    }

}
