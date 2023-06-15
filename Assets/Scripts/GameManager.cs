using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BubbleTypes { RED, YELLOW, BLUE, GREEN, BLACK, EXPLOSION };

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static Color GetBubbleColor(BubbleTypes type)
    {
        Color color = Color.white;

        switch (type)
        {
            case BubbleTypes.RED:
                color = Color.red;
                break;
            case BubbleTypes.YELLOW:
                color = Color.yellow;
                break;
            case BubbleTypes.BLUE:
                color = Color.blue;
                break;
            case BubbleTypes.GREEN:
                color = Color.green;
                break;
            case BubbleTypes.BLACK:
                color = Color.black;
                break;
            case BubbleTypes.EXPLOSION:
                color = Color.magenta;
                break;
        }

        return color;
    }
}
