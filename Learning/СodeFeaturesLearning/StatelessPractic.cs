using Stateless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPractice
{
    class StatelessPractic
    {
        public class Gun
        {
            private enum weaponStatus
            {
                holstered,
                unholstered,
                loadedAmmo,
                readyToShot,
                afterShot

            }
            private enum weaponAction
            {
                getOutOfTheHolster,
                insertnAmmo,
                reloadShutter,
                shot
            }
            private StateMachine<weaponStatus, weaponAction> stateMachine;
            private bool fingerOnTheTrigger = false;

            public Gun()
            {
                stateMachine = new StateMachine<weaponStatus, weaponAction>(weaponStatus.holstered);
                stateMachine.Configure(weaponStatus.holstered).Permit(weaponAction.getOutOfTheHolster, weaponStatus.unholstered);
                stateMachine.Configure(weaponStatus.unholstered).Permit(weaponAction.insertnAmmo, weaponStatus.loadedAmmo);
                stateMachine.Configure(weaponStatus.loadedAmmo).Permit(weaponAction.reloadShutter, weaponStatus.readyToShot);
                stateMachine.Configure(weaponStatus.readyToShot).Permit(weaponAction.shot, weaponStatus.afterShot);
            }

            public void GetOutOfTheHolster()
            {
                if (stateMachine.State == weaponStatus.holstered)
                {
                    stateMachine.Fire(weaponAction.getOutOfTheHolster);
                    Console.WriteLine($"Gun status {stateMachine.State} | Gun get out of the holster");
                }
                else
                {
                    Console.WriteLine("Only holstered gun can get out of the holster");
                }
            }
            public void InsertnAmmo()
            {
                if (stateMachine.State == weaponStatus.unholstered)
                {
                    stateMachine.Fire(weaponAction.insertnAmmo);
                    Console.WriteLine($"Gun status {stateMachine.State} | Ammo insert");
                }
                else
                {
                    Console.WriteLine("Can not insert ammo");
                }
            }
            public void ReloadShutter()
            {
                if (stateMachine.State == weaponStatus.loadedAmmo)
                {
                    stateMachine.Fire(weaponAction.reloadShutter);
                    Console.WriteLine($"Gun status {stateMachine.State} | Shultter reloaded");
                }
                else
                {
                    Console.WriteLine("Can not reload Shultter");
                }
            }
            public void Shot()
            {
                if (stateMachine.State == weaponStatus.readyToShot && fingerOnTheTrigger)
                {
                    stateMachine.Fire(weaponAction.shot);
                    Console.WriteLine("****Shot is hearding");
                }
                else
                {
                    Console.WriteLine("Can not shot");
                    if (!fingerOnTheTrigger)
                    {
                        Console.WriteLine($"Gun status {stateMachine.State} | Put you finget in trigger");
                    }
                }
            }
            public void PutYouFingetInTrigger() {
                if (stateMachine.State == weaponStatus.readyToShot)
                {
                    fingerOnTheTrigger = true;
                    Console.WriteLine($"Gun status {stateMachine.State} | Caution! You finget in trigger");
                }
                else {
                    Console.WriteLine($"Gun status is {stateMachine.State}, you can put you finget in trigger only readyToShot status");
                }
            }
            public void GetGunStatus() {
                Console.WriteLine($"Gun status is {stateMachine.State}");
            }
        }

    }
}
