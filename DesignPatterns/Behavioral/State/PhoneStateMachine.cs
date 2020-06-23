using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.State
{
    class PhonePhoneStateMachine
    {
        private static Dictionary<PhoneState, List<(PhoneTrigger, PhoneState)>> _rules
            = new Dictionary<PhoneState, List<(PhoneTrigger, PhoneState)>>
            {
                [PhoneState.OffHook] = new List<(PhoneTrigger, PhoneState)>
                {
                    (PhoneTrigger.CallDialed, PhoneState.Connecting)
                },
                [PhoneState.Connecting] = new List<(PhoneTrigger, PhoneState)>
                {
                    (PhoneTrigger.HungUp, PhoneState.OffHook),
                    (PhoneTrigger.CallConnected, PhoneState.Connected)
                },
                [PhoneState.Connected] = new List<(PhoneTrigger, PhoneState)>
                {
                    (PhoneTrigger.LeftMessage, PhoneState.OffHook),
                    (PhoneTrigger.HungUp, PhoneState.OffHook),
                    (PhoneTrigger.PlacedOnHold, PhoneState.OnHold)
                },
                [PhoneState.OnHold] = new List<(PhoneTrigger, PhoneState)>
                {
                    (PhoneTrigger.TakenOffHold, PhoneState.Connected),
                    (PhoneTrigger.HungUp, PhoneState.OffHook)
                }
            };

        public void Start()
        {
            var currentState = PhoneState.OffHook;

            while (true)
            {
                Console.WriteLine($"The phone is currently {currentState}");
                Console.WriteLine("Select a trigger:");

                for (var ruleIndex = 0; ruleIndex < _rules[currentState].Count; ruleIndex++)
                {
                    // Print options for current state
                    var (trigger, _) = _rules[currentState][ruleIndex];
                    Console.WriteLine($"{ruleIndex}. {trigger}");
                }

                int input = int.Parse(Console.ReadLine());

                var (_, state) = _rules[currentState][input];
                currentState = state;
            }
        }
    }
}
