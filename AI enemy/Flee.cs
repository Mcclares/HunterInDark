using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : AgentBehaviour
{
    public float maxPrediction;
    private GameObject targetAux;
    private Agent targetAgent;

   public override void Awake() {
        base.Awake();
        targetAgent = target.GetComponent<Agent>();
        targetAux = target;
        target = new GameObject();

    }
    private void OnDestroy() {
        Destroy(targetAux);
    }
    public override Steering GetSteering()
    {
        Vector3 direction = targetAux.transform.position - transform.position;
        float speed = agent.velocity.magnitude;
        float distance = direction.magnitude;
        float prediciton;
        if(speed <= distance / maxPrediction) {
            prediciton = maxPrediction;
        }
        else {
            prediciton = distance / speed;
        }
        target.transform.position = targetAux.transform.position;
        
        target.transform.position += targetAgent.velocity * prediciton;
        return base.GetSteering();
    }


    }