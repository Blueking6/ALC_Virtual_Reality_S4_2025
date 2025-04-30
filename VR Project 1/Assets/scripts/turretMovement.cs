using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretTurn : MonoBehaviour
{
    public int maxRotationSpeed;
    public GameObject 
    public JoystickControl joystickcontrol;
    
    void Start() {
        joystickcontrol = ;
    }
    void Update() {
        float angleXJoy = joystickcontrol.angleX;
        transform.Rotate(0,angleXJoy * maxRotationSpeed * Time.deltaTime,0);
    }
    
}
