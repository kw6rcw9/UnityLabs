using System;
using System.Collections;
using System.Collections.Generic;
using HotDogShop;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private HotDogSo classicHotDogData;
    [SerializeField] private HotDogSo ceasarHotDogData;
    [SerializeField] private HotDogSo meatHotDogData;
    private void Awake()
    {
        AHotDog classicDog = new HotDogClassic(classicHotDogData);
        var classicDogWithCuc = new Cucumber(classicDog);
        var classicDogWithOnion = new SweetOnion(new HotDogClassic(classicHotDogData));
        AHotDog cesarDog = new HotDogCesar(ceasarHotDogData);
        var cesarDogWithCuc = new Cucumber(cesarDog);
        var cesarDogWithOnion = new SweetOnion(new HotDogCesar(ceasarHotDogData));
        AHotDog meatDog = new HotDogMeat(meatHotDogData);
        var meatDogWithCuc = new Cucumber(meatDog);
        var meatDogWithOnion = new SweetOnion(new HotDogMeat(meatHotDogData));
        Debug.Log($"{classicDog.GetName}({classicDog.GetWeight()}г) - {classicDog.GetCost()}р\n" +
                  "Дополнительная информация:\n " +
                  $"{classicDogWithCuc.GetName}({classicDogWithCuc.GetWeight()}г) - {classicDogWithCuc.GetCost()}р\n" +
                  $"{classicDogWithOnion.GetName}({classicDogWithOnion.GetWeight()}г) - {classicDogWithOnion.GetCost()}р\n" +
                  $"{cesarDog.GetName}({cesarDog.GetWeight()}г) - {cesarDog.GetCost()}р\n" +
                  "Дополнительная информация:\n " +
                  $"{cesarDogWithCuc.GetName}({cesarDogWithCuc.GetWeight()}г) - {cesarDogWithCuc.GetCost()}р\n" +
                  $"{cesarDogWithOnion.GetName}({cesarDogWithOnion.GetWeight()}г) - {cesarDogWithOnion.GetCost()}р\n" +
                  $"{meatDog.GetName}({meatDog.GetWeight()}г) - {meatDog.GetCost()}р\n" +
                  "Дополнительная информация:\n " +
                  $"{meatDogWithCuc.GetName}({meatDogWithCuc.GetWeight()}г) - {meatDogWithCuc.GetCost()}р\n" +
                  $"{meatDogWithOnion.GetName}({meatDogWithOnion.GetWeight()}г) - {meatDogWithOnion.GetCost()}р\n");
    }
}
