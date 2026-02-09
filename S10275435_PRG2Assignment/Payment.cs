//==========================================================
// Student 1: Bryan (S10275435F)
// Student 2: Kyran (S10275200K)
//==========================================================

namespace S10275435_PRG2Assignment
{
    public class Payment
    {
        public string Method { get; set; } // CC, PP, CD

        public Payment(string method)
        {
            Method = method;
        }
    }
}