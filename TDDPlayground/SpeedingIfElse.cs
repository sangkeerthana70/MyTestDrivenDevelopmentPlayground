namespace TDDPlayground
{
    internal class SpeedingIfElse
    {
        int Speed { get; set; }



        public static string IssueSpeedTicket(int speed)
        {
            string ticket;
            if (speed <= 60)
            {
                ticket = "No ticket";
            }
            else if ((speed >= 61) && (speed <= 80))
            {
                ticket = "Small ticket";
            }
            else
            {
                ticket = "Big ticket";

            }


            return ticket;

        }
    }
}