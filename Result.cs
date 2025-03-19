using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_lab2
{
    class Result
    {
        public List<Item> SelectedItems { get; private set; } = [];
        private int TotalValue { get; set; } = 0;
        private int TotalWeight { get; set; } = 0;

        public void AddItem(Item item)
        {
            SelectedItems.Add(item);
            TotalValue += item.GetValue();
            TotalWeight += item.GetWeight();
        }

        public override string ToString()
        {
            return $"Total Value: {TotalValue}, Total Weight: {TotalWeight}\nItems:\n{string.Join("\n", SelectedItems)}";
        }
    }

}
