using System;

namespace DesignPatterns.Behavioral.Observer
{
    public class Game
    {
        public event EventHandler RatEntersGame, RatDies;

        public event EventHandler<Rat> RatNotifyOtherRatAboutHisPresence;

        public void AddRat(object sender)
        {
            RatEntersGame?.Invoke(sender, null);
        }

        public void RemoveRat(object sender)
        {
            RatDies?.Invoke(sender, null);
        }

        public void NotifyRatAboutOthersPresence(object sender, Rat rat)
        {
            RatNotifyOtherRatAboutHisPresence?.Invoke(sender, rat);
        }
    }
}
