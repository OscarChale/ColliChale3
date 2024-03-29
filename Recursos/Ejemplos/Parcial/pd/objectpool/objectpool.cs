public class AutomatedPicker
{
    public AutomatedPicker(int pickerId)
    {
        PickerId = pickerId;
        CurrentLocation = "Recharging Station";
    }
 
    public int PickerId { get; private set; }
 
    public string CurrentLocation { get; private set; }
 
    public string Carrying { get; private set; }
 
    public void Identify(string code)
    {
        ShowMessage("Identified as " + code);
    }
 
    public void GoToLocation(string location)
    {
        CurrentLocation = location;
        ShowMessage("At " + location);
    }
 
    public void Pick(string item)
    {
        Carrying = item;
        ShowMessage("Picked Up " + item);
    }
 
    public void Drop()
    {
        ShowMessage("Dropped " + Carrying);
        Carrying = null;
    }
 
    public void ShowMessage(string msg)
    {
        Console.WriteLine("Picker {0} : {1}", PickerId, msg);
    }
}