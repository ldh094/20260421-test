using UnityEngine;

public class Flipper : MonoBehaviour
{
    public float motorSpeed = 1000f;
    public float motorForce = 10000f;

    private HingeJoint2D hinge;
    private JointMotor2D motor;

    public KeyCode controlKey = KeyCode.Space;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        motor = hinge.motor;

        motor.maxMotorTorque = motorForce;
        hinge.useMotor = true;
    }

    void Update()
    {
        if (Input.GetKey(controlKey))
        {
            // Å° ´©¸£¸é À§·Î Æ¨±è
            motor.motorSpeed = motorSpeed;
        }
        else
        {
            // Å° ¶¼¸é ¿øÀ§Ä¡·Î º¹±Í
            motor.motorSpeed = -motorSpeed;
        }

        hinge.motor = motor;
    }
}