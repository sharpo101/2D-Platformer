using Godot;
using System;

public partial class GameManager : Node
{	
	public static int points = 0;
	
	public Label PointsLabel;
	
	public void addPoint()
	{
		points = points + 1;
		GD.Print(points);
		
	}
	
	public override void _Process(double delta)
	{
		PointsLabel = GetNode<Label>("/root/Node/UI/Panel/PointsLabel");
		PointsLabel.Text = $"Points: {points.ToString()}";
	}

}
