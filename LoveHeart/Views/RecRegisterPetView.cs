﻿using LoveHeart.Actions;
using LoveHeart.Domain;
using LoveHeart.Services;
using System;

namespace LoveHeart.Views
{
    class RecRegisterPetView
    {
        public static void PetRegView(PetOwner petowner)
        {
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();

            Console.WriteLine("Adding a pet");
            Console.WriteLine();
            Tools.WriteAt(Config.fromBorder, 4, $"Owner: {petowner.FirstName} {petowner.LastName}");
            Tools.WriteAt(Config.fromBorder, 6, "Pet information");
            Console.WriteLine();

            Tools.WriteAt(Config.fromBorder, 7, "Name:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Tools.WriteAt(Config.fromBorder, 8, "Nickname:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string nickname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Tools.WriteAt(Config.fromBorder, 9, "Type of animal:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string typeOfAnimal = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Tools.IsThisCorrectTextLower();
            char correct = Console.ReadKey().KeyChar;

            if (correct == 'y' || correct == 'Y')
            {
                petowner.OwnerAnimals.Add(new Pet(name, nickname, typeOfAnimal));
                Pet pet = new Pet(name, nickname, typeOfAnimal);
                CustomerSaver.AddOneAndSave(petowner, pet);
                RecMenu.MenuView();
            }
            else
            {
                PetRegView(petowner);
            }
            Console.ReadKey();
        }
    }
}
