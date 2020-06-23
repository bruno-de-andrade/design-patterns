using System;

namespace DesignPatterns.Behavioral.Observer
{
    public sealed class Rat : IDisposable
    {
        public int Attack = 1;

        private Game _game;

        public Rat(Game game)
        {
            _game = game;

            _game.RatEntersGame += IncreaseAttack;
            _game.RatDies += DecreaseAttack;
            _game.RatNotifyOtherRatAboutHisPresence += ReceivePresenceNotification;

            _game.AddRat(this);
        }

        public void Dispose()
        {
            _game.RemoveRat(this);
        }

        private void IncreaseAttack(object sender, EventArgs eventArgs)
        {
            if (sender != this)
            {
                Attack++;

                _game.NotifyRatAboutOthersPresence(this, (Rat)sender);
            }
        }

        private void DecreaseAttack(object sender, EventArgs eventArgs)
        {
            if (sender != this)
            {
                Attack--;
            }
        }

        private void ReceivePresenceNotification(object sender, Rat recipientRat)
        {
            if (recipientRat == this)
            {
                Attack++;
            }
        }
    }
}
