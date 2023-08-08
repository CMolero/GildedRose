using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> items)
        {
            Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.SellIn--;

                    if (item.Name == "Aged Brie")
                    {
                        UpdateAgedBrie(item);
                    }
                    else if (item.Name == "Backstage passes to an TAFKAL80ETC concert")
                    {
                        UpdateBackstagePass(item);
                    }
                    else if (item.Name.StartsWith("Conjured"))
                    {
                        UpdateConjured(item);
                    }
                    else
                    {
                        UpdateNormalItem(item);
                    }

                    // Ensure quality bounds
                    if (item.Quality > 50)
                    {
                        item.Quality = 50;
                    }
                    else if (item.Quality < 0)
                    {
                        item.Quality = 0;
                    }
                }
            }
        }

        private void UpdateNormalItem(Item item)
        {
            int qualityChange = item.SellIn > 0 ? 1 : 2;
            item.Quality -= qualityChange;
        }

        private void UpdateAgedBrie(Item item)
        {
            int qualityChange = item.SellIn > 0 ? 1 : 2;
            item.Quality += qualityChange;
        }

        private void UpdateBackstagePass(Item item)
        {
            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn <= 5)
            {
                item.Quality += 3;
            }
            else if (item.SellIn <= 10)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality++;
            }
        }

        private void UpdateConjured(Item item)
        {
            int qualityChange = item.SellIn > 0 ? 2 : 4;
            item.Quality -= qualityChange;
        }
    }

}
