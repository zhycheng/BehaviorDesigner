using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

public class MyConditionalCompareBig : Conditional
{
	public SharedInt int1;
	public SharedInt int2;

	public override TaskStatus OnUpdate()
	{
		if(int1.Value>int2.Value)
		{
			return TaskStatus.Success;
		}
		else
		{
			return TaskStatus.Failure;
		}
	}
}
