using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluePrints : MonoBehaviour
{

    public enum bluePrintsEnum
    {
        Walkman
    }

    public  List<bluePrintsEnum> ownedBluePrints = new List<bluePrintsEnum>(); 

    public void addBluePrint(bluePrintsEnum bluePrintToAdd)
    {
        ownedBluePrints.Add(bluePrintToAdd);
    }

    public bool checkIfBluePrintOwned(bluePrintsEnum bluePrint)
    {
        return ownedBluePrints.Contains(bluePrint);
    }

}
