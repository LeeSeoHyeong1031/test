using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : IState
{
	private Player _player;

	public AttackState(Player player)
	{
		this._player = player;
	}

	public void OnEnter()
	{
		if (_player.isLeftMouseClick)
		{
			_player._curWeopon.CanNormalAttack();
		}
		else if (_player.isRightMouseClick)
		{
			_player._curWeopon.CanSkillAttack();
		}
	}

	public void OnUpdate()
	{
		if (_player._curWeopon.isAttack == false)
		{
			_player.playerStateMachine.TransitionTo(_player.playerStateMachine.idleState);
		}
	}

	public void OnExit()
	{

	}

}
