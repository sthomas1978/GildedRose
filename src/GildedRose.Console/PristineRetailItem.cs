﻿namespace GildedRose.Console
{
    public class PristineRetailItem : RetailItem
    {
        public PristineRetailItem(Item item) : base(item){ }

        public override void UpdateQuality()
        {
            // dont do anything;
        }
    }

}
