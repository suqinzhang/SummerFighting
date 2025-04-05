using UnityEngine;

public class SetOrder : MonoBehaviour
{
    public Canvas canvasToControl;
    private bool IsUp { get; set; }

    public void Up()
    {
        if (IsUp)
        {
            IsUp = false;
            canvasToControl.sortingOrder = 25;
        }
        else
        {
            canvasToControl.sortingOrder=35;
            IsUp = true;
        }
        
    }

    public void Down()
    {
        IsUp = false;
        canvasToControl.sortingOrder=25;
    }
}
