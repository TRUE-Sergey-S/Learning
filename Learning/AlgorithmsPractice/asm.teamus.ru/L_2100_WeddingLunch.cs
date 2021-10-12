using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.AlgorithmsPractice.asm.teamus.ru
{
    public class L_2100_WeddingLunch
    {
        int onePersonPice = 100;
        int startInviteCounte = int.Parse(Console.ReadLine());
        int inviteCounte = 0;
        public L_2100_WeddingLunch()
        {
            for (int i = 0; i < startInviteCounte; i++)
            {
                inviteCounte++;
                if (Console.ReadLine().Contains("+one"))
                {
                    inviteCounte++;
                }
            }
            inviteCounte = inviteCounte + 2;
            if (inviteCounte == 13)
            {
                inviteCounte++;
            }
            inviteCounte = inviteCounte * onePersonPice;
            Console.Write(inviteCounte);
        }
    }
}
