using UnityEngine;
using TMPro;

public class Bonus : MonoBehaviour
{
    public int bonusCount;
    private TextMeshProUGUI bonusText;
    
    // Start is called before the first frame update
    void Start()
    {
        bonusText = transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();
        bonusText.text = bonusCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
