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
            BarAndHotelsMenuOption.NumberPlaces = 35;

            // * Fine Dining
            FineDiningMenuOption.Title = "Fine Dining";
            FineDiningMenuOption.Image = "FineDiningImage";
            FineDiningMenuOption.NumberPlaces = 25;

            // * Cafes
            CafesMenuOption.Title = "Cafes";
            CafesMenuOption.Image = "CafesImage";
            CafesMenuOption.NumberPlaces = 12;

            // * Nearby
            NearbyMenuOption.Title = "Nearby";
            NearbyMenuOption.Image = "NearbyImage";
            NearbyMenuOption.NumberPlaces = 45;

            // * Fast Foods
            FastFoodsMenuOption.Title = "Fast Foods";
            FastFoodsMenuOption.Image = "FastFoodsImage";
            FastFoodsMenuOption.NumberPlaces = 15;

            // * Featured Foods
            FeaturedFoodsMenuOption.Title = "Featured Foods";
            FeaturedFoodsMenuOption.Image = "FeaturedFoodsImage";
            FeaturedFoodsMenuOption.NumberPlaces = 23;
        }
    }
}
