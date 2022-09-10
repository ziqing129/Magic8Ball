﻿using Magic8Ball.ConsoleApp;
using Magic8Ball.ConsoleApp.Pets;

var dogPet = new Dog("Milo");
var catPet = new Cat("Songxiaogou");
var robotPet = new Robot("Cherry");

Console.WriteLine(dogPet.GetInformation());
Console.WriteLine(catPet.GetInformation());
Console.WriteLine(robotPet.GetInformation());