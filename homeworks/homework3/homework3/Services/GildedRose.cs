using homework3.Interfaces;
using homework3.Services;
using System.Collections.Generic;

namespace homework3
{
    public class GildedRose
    {
        private IValidate validate = new Validate();
        private IOperations operations = new Operations();
        private IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if(!validate.NameEquals(Items[i], "Aged Brie") && !validate.NameEquals(Items[i], "Backstage passes to a TAFKAL80ETC concert"))
                {
                    if (!validate.QualityLowerThan(Items[i],0))
                    {
                        if (!validate.NameEquals(Items[i], "Sulfuras, Hand of Ragnaros"))
                        {
                            operations.DecrementQuality(Items[i], 1);
                        }
                    }
                }
                else
                {
                    if (validate.QualityLowerThan(Items[i],50))
                    {
                        operations.IncrementQuality(Items[i], 1);

                        if (!validate.NameEquals(Items[i], "Backstage passes to a TAFKAL80ETC concert"))
                        {
                            if (validate.SellInLowerThan(Items[i], 11))
                            {
                                if (validate.QualityLowerThan(Items[i], 50))
                                {
                                    operations.IncrementQuality(Items[i], 1);
                                }
                            }

                            if (validate.SellInLowerThan(Items[i] , 6))
                            {
                                if (validate.QualityLowerThan(Items[i], 50))
                                {
                                    operations.IncrementQuality(Items[i], 1);
                                }
                            }
                        }
                    }
                }

                if (!validate.NameEquals(Items[i], "Sulfuras, Hand of Ragnaros"))
                {
                    operations.DecrementSellIn(Items[i], 1);
                }

                if (validate.SellInLowerThan(Items[i], 0))
                {
                    if (!validate.NameEquals(Items[i], "Aged Brie"))
                    {
                        if (!validate.NameEquals(Items[i], "Backstage passes to a TAFKAL80ETC concert"))
                        {
                            if (!validate.QualityLowerThan(Items[i], 0))
                            {
                                if (!validate.NameEquals(Items[i], "Sulfuras, Hand of Ragnaros"))
                                {
                                    operations.DecrementQuality(Items[i], 1);
                                }
                            }
                        }
                        else
                        {
                            operations.DecrementQuality(Items[i], Items[i].Quality);
                        }
                    }
                    else
                    {
                        if (validate.QualityLowerThan(Items[i], 50))
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                            operations.IncrementQuality(Items[i], 1);
                        }
                    }
                }
            }
        }
    }
}
