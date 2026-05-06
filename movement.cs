using Godot;
using System;

public partial class movement : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float AMOUNT = 5;
		if (Input.IsKeyPressed((int)Key.W)){
			Position += new Vector2(0,-AMOUNT);
		}
	}
}
