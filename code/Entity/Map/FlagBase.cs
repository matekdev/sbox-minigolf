﻿namespace Facepunch.Minigolf.Entities;

[Library( "minigolf_flag_base")]
[HammerEntity, EditorModel( "models/minigolf_flag.vmdl" )]
[Title( "Flag Pole" )]
public partial class FlagBase : ModelEntity
{
	static readonly Model FlagModel = Model.Load( "models/minigolf_flag.vmdl" );

	public override void Spawn()
	{
		base.Spawn();

		Model = FlagModel;

		PhysicsEnabled = false;
		UsePhysicsCollision = false;

		Transmit = TransmitType.Always;
	}
}
