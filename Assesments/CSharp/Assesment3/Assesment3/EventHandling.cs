using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assesment3
{
    class EventHandlers
    {


        class MobilePhone
        {
            public class RingEventHandler : EventArgs
            {
                public string Message { get; set; }
            }

            public EventHandler<RingEventHandler> Ring;
            public void OnRing(string message)
            {
                Ring?.Invoke(this, new RingEventHandler
                {
                    Message = message
                });
            }
            public void ReceiveCall(string message)
            {
                OnRing(message);
            }
        }
        class RingtonePlayer
        {
            public void PlayRingtone(object sender, MobilePhone.RingEventHandler e)
            {
                Console.WriteLine("Playing RingTone");
            }
        }
        class ScreenDisplay
        {
            public void ShowDisplay(object sender, MobilePhone.RingEventHandler e)
            {
                Console.WriteLine("Displaying Caller Information");
            }
        }
        class VibrationMotor
        {
            public void Vibrate(object sender, MobilePhone.RingEventHandler e)
            {
                Console.WriteLine("Phone is Vibrating");
            }
        }
        static void Main()
        {
            MobilePhone phone = new MobilePhone();

            RingtonePlayer ringtone = new RingtonePlayer();
            ScreenDisplay screen = new ScreenDisplay();
            VibrationMotor vibration = new VibrationMotor();


            phone.Ring += ringtone.PlayRingtone;
            phone.Ring += screen.ShowDisplay;
            phone.Ring += vibration.Vibrate;

            
            phone.ReceiveCall("Incoming Call");
        }
    }
 }

