using UnityEngine;
public class Agent : SBAgent
{
	Vector2 center;
	Vector2 position;

	float maxDistance;

	public Transform target;
	public Transform agente;
	//public Transform target2;

	void Start()
	{
		maxSpeed = 3f;
		maxSteer = 0.5f;
		agente = GameObject.Find("Agent").transform;
		target = GameObject.Find("Target").transform;
	}

	void Update()
	{
		float actualDistancia = Vector2.Distance(center,position);



		velocity += SteeringBehaviours.Arrive(this,target,1f);
		velocity += SteeringBehaviours.Seek(this,target,1);
		//velocity += SteeringBehaviours.Flee(this, target2,1);
		//velocity += SteeringBehaviours.Separate(this, GameManager.agents, 2f);
		transform.position += velocity * Time.deltaTime;
	}
}
