namespace Zillow.Services
{
    // --- System
    using System;
    using System.Text;

    public class ZEstimate
    {
        private long amount = 0;
        private string updated = string.Empty;
        private long low = 0;
        private long high = 0;

        public long Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Updated
        {
            get { return updated; }
            set { updated = value; }
        }

        public long Low
        {
            get { return low; }
            set { low = value; }
        }

        public long High
        {
            get { return high; }
            set { high = value; }
        }

        public ZEstimate()
        {
        }

    }
}
