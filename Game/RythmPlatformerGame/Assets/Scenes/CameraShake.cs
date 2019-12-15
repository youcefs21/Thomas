using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
	// Transform of the camera to shake. Grabs the gameObject's transform
	// if null.
	public Transform camTransform;
	
	// How long the object should shake for.
	public float shakeDuration = 0f;
	
	// Amplitude of the shake. A larger value shakes the camera harder.
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1.0f;
	
	Vector3 originalPos;
	
	void Awake()
	{
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}
	
	void OnEnable()
	{
		originalPos = camTransform.localPosition;
	}

	void Update()
	{
        if (TimeManager.ts.TotalSeconds > 83.2 && TimeManager.ts.TotalSeconds < 83.4)
        {
            shakeDuration = 0.8f;
        }

        if (TimeManager.ts.TotalSeconds > 65 && TimeManager.ts.TotalSeconds < 65.2)
        {
            originalPos = camTransform.localPosition;
            shakeDuration = 0.8f;
        }

        if (TimeManager.ts.TotalSeconds > 47 && TimeManager.ts.TotalSeconds < 47.2)
        {
            originalPos = camTransform.localPosition;
            shakeDuration = 0.8f;
        }

        if (shakeDuration > 0)
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
			
			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
		else
		{
			shakeDuration = 0f;
            originalPos = camTransform.localPosition;
            //camTransform.localPosition = originalPos;
        }
    }
}
