using TMPro;
using UnityEngine;

public class ShopLevel : MonoBehaviour
{
    [SerializeField] private GameObject BlockedBtn;
    [SerializeField] private int LevelNum; 
    private TextMeshProUGUI text;


    public void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = LevelNum.ToString();
        if (PlayerPrefs.GetInt(LevelNum-1 + "LevelIsFinish") == 1)
        {
            BlockedBtn.SetActive(false);
        } else
        {
            BlockedBtn.SetActive(true);
        }
    }
}
