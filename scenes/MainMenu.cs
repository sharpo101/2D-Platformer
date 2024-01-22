using Godot;
using System;

public partial class MainMenu : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _on_level_1_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/level1.tscn");
	}

	private void _on_level_2_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/level2.tscn");
	}
}



