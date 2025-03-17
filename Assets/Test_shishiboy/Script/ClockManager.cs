using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ClockManager : MonoBehaviour
{
    public Sprite highlightedSprite;
    public Image buttonImage;
    public Sprite normalSprite; 
    
    // Start is called before the first frame update
    void Start()
    {
        buttonImage = GetComponent<Image>();
        normalSprite = buttonImage.sprite;
    }

    public void OnPointerEnter()
    {
        buttonImage.sprite = highlightedSprite; 
    }

public void OnPointerExit()
{
buttonImage.sprite = normalSprite; 
}
}
