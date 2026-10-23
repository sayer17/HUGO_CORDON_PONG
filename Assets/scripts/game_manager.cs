using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class game_manager : MonoBehaviour
{
    public int PuntosP1=0;
    public int PuntosP2=0;
    public string PointsCount;
    public TextMeshProUGUI marcadorText;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PointsCount);
    }

    // Update is called once per frame
    public void UpdatePointsText()
    {
        PointsCount = PuntosP1 + "|" + PuntosP2;
        marcadorText.text = PointsCount;
    }
    
}
