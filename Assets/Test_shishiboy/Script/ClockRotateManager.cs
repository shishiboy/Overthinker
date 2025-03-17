using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotateManager : MonoBehaviour
{
    public float rotationPerSecond = 6f; // 360 degrees / 60 seconds = 6 degrees per second
    private int secondsPassed = 0;
    private Quaternion originalRotation;

    void Start()
    {
        originalRotation = transform.rotation;
        InvokeRepeating(nameof(RotateClock), 1f, 1f); // Call RotateClock every 1 second
    }

    public void RotateClock()
    {
        if (secondsPassed < 60)
        {
            transform.Rotate(0, 0, -rotationPerSecond); // Rotate clockwise
            secondsPassed++;
        }
        else
        {
            // Reset after 60 seconds
            transform.rotation = originalRotation;
            secondsPassed = 0;
        }
    }
    public void StopRotation()
    {
        // InvokeRepeatingで登録したRotateClock呼び出しをキャンセル
        CancelInvoke(nameof(RotateClock));
    }
    public void ResumeRotation()
    {
        // まだ登録されていない場合のみ呼び出す
        if (!IsInvoking(nameof(RotateClock)))
        {
            InvokeRepeating(nameof(RotateClock), 1f, 1f);
        }
    }

}
