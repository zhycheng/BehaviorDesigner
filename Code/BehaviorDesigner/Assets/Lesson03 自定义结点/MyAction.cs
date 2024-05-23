using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

public class MyAction : Action
{
	public SharedInt time;
	public override TaskStatus OnUpdate()
	{
		time.Value = Random.Range(1,10);
		return TaskStatus.Success;
	}
}
