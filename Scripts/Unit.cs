using Godot;
using System;

public partial class Unit : CharacterBody2D {
	public const float Speed = 300.0f;
	public const float Damage = 10f;

	public const bool isEnemy = true;



	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta) {
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor()) {
			velocity.Y += gravity * (float)delta;
		}

		if (isEnemy) {
			velocity.X = -100;
		}
		else
			velocity.X = 100;

		Velocity = velocity;
		MoveAndSlide();
	}
}
