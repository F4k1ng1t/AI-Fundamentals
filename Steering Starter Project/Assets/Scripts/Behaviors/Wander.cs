using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : Seek
{
    float wanderOffset = 5f;
    float wanderRadius = 1f;
    float wanderOrientation = 0f;
    float wanderRate = 5f;

    float maxAcceleration = 100f;

    public override SteeringOutput getSteering()
    {
        SteeringOutput result = new SteeringOutput();
        wanderOrientation = Random.insideUnitCircle.y * wanderRate;
        float targetOrientation = wanderOrientation + character.transform.rotation.y;

        target.transform.position = character.transform.position + (wanderOffset * new Vector3(0, character.transform.rotation.y, 0);
        target.transform.position += wanderRadius * new Vector3(0, targetOrientation, 0);
        result = Seek.getSteering();
        result.linear = maxAcceleration * character.transform.rotation;
        return result;
    }
    protected override Vector3 getTargetPosition()
    {
        return new Vector3();
    }
}
