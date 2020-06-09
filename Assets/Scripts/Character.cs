using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour //Parent
{
    //private int energy; 

    //public int Energy //property ????
    //{
    //    get
    //    {
    //        return energy;
    //    }

    //    private set //you can set the value only inside the character
    //    {
    //        energy = value;
    //    }
    //}

        //WELL, I COMMENTED THIS BLOCK 'CAUSE YOU MIGHT FORGET

    public int Energy { get; set; }
    public int Attack { get; set; }
    public int Defence { get; set; }
    public int Gold { get; set; }
    public Vector2 RoomIndex { get; set; } //where character is

    public List<string> Inventory { get; set; } //this is dynamic, array is not
}
