using UnityEngine;

public class Alinna_Congratulations_1 : EventBase
{
    public override void StartEvent()
    {
        Text = "You've picked up everything, good job. Now hurry!";
        ConversationActor = Actors.AI_Alinna();

        AddContinueChoice();
    }
}
