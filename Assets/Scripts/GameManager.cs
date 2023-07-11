using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Store reference to each car in the game
    [SerializeField] private Car[] allRacecarsArray;
    [SerializeField] private List<Car> allRacecarsList = new List<Car>();

    // Start is called before the first frame update
    void Start()
    {
        // Want to output the names of all the cars

        // For Array
        Debug.Log(allRacecarsArray.Length);
        Debug.Log(allRacecarsArray[3].name);

        // For List
        Debug.Log(allRacecarsList.Count);
        Debug.Log(allRacecarsList[3].name);

        CheckWhichCarIsCrashed();
        
    }

    private void CheckWhichCarIsCrashed()
    {
        // use a for loop
        for (int selectedCarIndex = 0; selectedCarIndex < allRacecarsArray.Length; selectedCarIndex++)
        {
            if (allRacecarsList[selectedCarIndex].isCrashed == true)
            {
                Debug.Log("CRASHED " + selectedCarIndex);
                Debug.Log("A car has crashed: [" + allRacecarsList[selectedCarIndex].name + "]!");
            }
        }
    }

    public void HelloWorldButton()
    {
        Debug.Log("Hello World from a UI Button!");
    }
}
