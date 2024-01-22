using Godot;
using System;

public partial class finish : Area2D
{
	[Export]
	public PackedScene targetLevel;

	private void _on_body_entered(Node2D body)
	{
		if (body.Name == "CharacterBody2D")
		{
			GetTree().ChangeSceneToPacked(targetLevel);
		}
	}
}


