using Godot;
using System;

public partial class Actor : CharacterBody2D
{
	public float maxSpeed;
	public float jumpStrength;
	public string displayName;
	public string intName;
	public Vector2 velocity = new Vector2(0, 0);


	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		// Add the gravity.
		if (!IsOnFloor())
		{
			velocity.Y += gravity * (float)delta;
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}
