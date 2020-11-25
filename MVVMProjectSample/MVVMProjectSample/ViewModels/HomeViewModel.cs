using MVVMProjectSample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMProjectSample.ViewModels
{
    class HomeViewModel
    {
        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FineDiningMenuOption { get; set; } = new MenuOption();
        public MenuOption CafesMenuOption { get; set; } = new MenuOption();
        public MenuOption NearbyMenuOption { get; set; } = new MenuOption();
        public MenuOption FastFoodsMenuOption { get; set; } = new MenuOption();
        public MenuOption FeaturedFoodsMenuOption { get; set; } = new MenuOption();

        public HomeViewModel()
        {
            // Menu Options

            // * Bar and Hotels

            BarAndHotelsMenuOption.Title = "Bar and Hotels";
            BarAndHotelsMenuOption.Image = "BarAndHotelsImage";

            // * Fine Dining
            FineDiningMenuOption.Title = "Fine Dining";
            FineDiningMenuOption.Image = "FineDiningImage";

            // * Cafes
            CafesMenuOption.Title = "Cafes";
            CafesMenuOption.Image = "cafesImage";

            // * Nearby
            NearbyMenuOption.Title = "Nearby";
            NearbyMenuOption.Image = "NearbyImage";

            // * Fast Foods
            FastFoodsMenuOption.Title = "Fast Foods";
            FastFoodsMenuOption.Image = "FastFoodsImage";

            // * Bar and Hotels
            FeaturedFoodsMenuOption.Title = "Featured Foods";
            FeaturedFoodsMenuOption.Image = "FeaturedFoodsImage";
        }
    }
}
