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
    public float minusY;
    public float minusX;
    
    void Start() {
        
    }
    void Update() {
        joystickAngleX = JoystickA.transform.Find("Hinge").rotation.x;
        if (joystickAngleX >= minusX) {
            joystickAngleX -= minusX;
        } 
        if (joystickAngleX <= -minusX) {
            joystickAngleX += minusX;
        } 
        joystickAngleY = JoystickB.transform.Find("Hinge").rotation.x;
        if (joystickAngleY >= minusY) {
            joystickAngleY -= minusY;
        } 
        if (joystickAngleY <= -minusY) {
            joystickAngleY += minusY;
        } 
        Debug.Log(joystickAngleX);

        transform.Rotate(0,joystickAngleY * maxRotationSpeed * Time.deltaTime,0);

        transform.Rotate(joystickAngleX * maxRotationSpeed * Time.deltaTime,0,0);
    }
    
}
