using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretTurn : MonoBehaviour
{
    public int maxRotationSpeed;
    public GameObject JoystickA;
    public GameObject JoystickB;
    public float joystickAngleX;
    public float joystickAngleY;
    
    void Start() {
        
    }
    void Update() {
        joystickAngleX = JoystickA.transform.Find("Hinge").rotation.x;
        joystickAngleY = JoystickB.transform.Find("Hinge").rotation.x;
        Debug.Log(joystickAngleX);
        Debug.Log(joystickAngleY);
        if(joystickAngleX >= .81f || joystickAngleX <= -.81f) {
        transform.Rotate(0,joystickAngleX * maxRotationSpeed * Time.deltaTime,0);
        }
        if(.5 <= joystickAngleY && joystickAngleY <= .7f || joystickAngleY <= -.81f) {
        transform.Rotate(joystickAngleY * maxRotationSpeed * Time.deltaTime,0,0);
        }
    }
    
}
