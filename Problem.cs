using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("UnitTests"), InternalsVisibleTo("GUI-Knapsack")]

namespace dotnet_lab2
{
    class Problem
    {
        public List<Item> Items { get; private set; }
        public Problem(int n, int seed)
        {
            Random random = new(seed);
            Items = [];

            for (int i = 0; i < n; i++)
            {
                int value = random.Next(1, 11); // losowa wartość 1-10
                int weight = random.Next(1, 11); // losowa waga 1-10
                Items.Add(new Item(value, weight));
            }
        }

        public Result Solve(int capacity)
        {
            var orderedItems = Items.OrderByDescending(i => (double) i.GetValue() / i.GetWeight());
            Result result = new Result();
            int currentWeight = 0;

            foreach (var item in orderedItems)
            {
                if (currentWeight + item.GetWeight() <= capacity)
                {
                    result.AddItem(item);
                    currentWeight += item.GetWeight();
                }
            }
            return result;
        }

        public override string ToString()
        {
            return string.Join("\n", Items);
        }
    }

}
