using SnakeAndLadder;

UC_1_SinglePlayer.SinglePlayer();
UC_2_PlayerRollsTheDie.DiceRoll();
UC_3_PlayerChecksForOptions.OptionsChecking();
UC_4_PlayerAtWinPosition.WinPosition();
UC_5_ExactWinPosition.WiningPosition();
UC_6_ReportingNumberOfDiceRolled.NumberOfDiceRolled();
UC_7_TwoPlayers player1= new UC_7_TwoPlayers();
int a = player1.Dice();
UC_7_TwoPlayers player2= new UC_7_TwoPlayers();
int b = player2.Dice();
if(b<a)
{
    Console.WriteLine("Player 2 wins");
}
else if (b>a)
{
    Console.WriteLine("Player 1 wins");
}