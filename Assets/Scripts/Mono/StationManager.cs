using UnityEngine;

public enum StationType
{
    CustomerStation,
    GelatoStation,
    CoffeeStation
}
public class StationManager : MonoBehaviour
{
    int currentStationIndex; //the index of the current station in the station array
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchStation(StationType stationType)
    {
        //switches to the specified station type
    }

    void disableStationSwitching()
    {
        //disables station switching
    }

    void enableStationSwitching()
    {
        //enables station switching
    }
}
