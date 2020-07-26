using Godot;
using System;

public class PlayerMovement : RigidBody2D {
	[Export]
	public int Acceleration;

	[Export]
	public int MaxAcceleration;

	public override void _Ready() { }

	public override void _Process(float delta) {
		if (Input.IsActionPressed("ui_left")) {
			ApplyTorqueImpulse(-Acceleration);
		}

		if (Input.IsActionPressed("ui_right")) {
			ApplyTorqueImpulse(Acceleration);
		}
	}
}
