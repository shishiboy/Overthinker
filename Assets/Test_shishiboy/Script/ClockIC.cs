using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClockIC : MonoBehaviour
{
public Sprite highlightedSprite; // カーソルが重なったときの画像
private Image buttonImage;
private Sprite normalSprite; // ボタンの通常の画像
[SerializeField] private GameObject anotherObject;
    
private ClockRotateManager clockRotateManager;

void Start()
{
buttonImage = GetComponent<Image>();
normalSprite = buttonImage.sprite; 
clockRotateManager = anotherObject.GetComponent<ClockRotateManager>();
}

public void OnPointerEnter()
{
buttonImage.sprite = highlightedSprite; 
clockRotateManager.StopRotation();
}

public void OnPointerExit()
{
buttonImage.sprite = normalSprite;
clockRotateManager.ResumeRotation();
}
}