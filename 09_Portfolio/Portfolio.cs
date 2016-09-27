using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        private List<IAsset> assetList;

        public Portfolio()
        {
            assetList = new List<IAsset>();
        }

        public Portfolio(List<IAsset> stocks)
        {
            this.assetList = stocks;
        }

        internal double GetTotalValue()
        {
            double result = 0;
            foreach (IAsset asset in assetList)
                result += asset.GetValue();

            return result;
        }

        internal void AddAsset(IAsset asset)
        {
            assetList.Add(asset);
        }
    }
}