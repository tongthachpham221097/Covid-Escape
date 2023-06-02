using UnityEngine.UI;

public class BaseText : LoboBehaviour
{
    public Text text;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.text = GetComponent<Text>();
    }
}
