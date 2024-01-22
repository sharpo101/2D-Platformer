using Godot;
using System;

public partial class collectable : Area2D
{
	GameManager gameManager = new GameManager();


	public void _on_body_entered(Node2D body)
	{
		// check if the character is colliding with collectible
		if (body.Name == "CharacterBody2D")
		{
			gameManager.addPoint();
			QueueFree();
		}
		
	}
}
